using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBMMS.DAL
{
    public class DALSSTEM
    {
        private string customerCode;
        public DALSSTEM()
        { }

        #region AZL
        public List<DataTable> GetAZL(DateTime date)
        {
            char letter = (char)(Convert.ToInt16(date.Year.ToString().Substring(2,2)) + 65);
            //string folder = letter + date.Month.ToString().PadLeft(2, '0') + date.Day.ToString().PadLeft(2, '0');
            string folder = "OP" + date.Month.ToString().PadLeft(2, '0') + date.Day.ToString().PadLeft(2, '0');

            string searchPattern = "OP" + date.Year.ToString().Substring(2, 2) + date.Month.ToString().PadLeft(2, '0') + date.Day.ToString().PadLeft(2, '0') +  "*";
            //string searchPattern = "OP*";
            
            string[] files = Directory.GetFiles(@"u:\gps900\logging\", searchPattern);
            string[] users = File.ReadAllLines(@"U:\GPS900\logging\$$SSTEMU.USQ");

            DataTable dt = new DataTable();
            dt.Columns.Add("USER");
            dt.Columns.Add("USER_NAME");
            dt.Columns.Add("CIB");
            dt.Columns.Add("VER_UNFILED");
            dt.Columns.Add("VER_FILED");
            dt.Columns.Add("RAT");
            dt.Columns.Add("EIF");
            dt.Columns.Add("APC");
            dt.Columns.Add("APF");
            dt.Columns.Add("DUPLICATED_IVF");
            dt.Columns.Add("QUERIED");
            dt.Columns.Add("RECLASSIFIED");
            dt.Columns.Add("EDITED");
            dt.Columns.Add("EDITED_PREV_RATIFIED");
            dt.Columns.Add("DELETED");

            DataTable dtID = new DataTable();
            dtID.Columns.Add("USER");
            dtID.Columns.Add("TRACKING_ID");
            dtID.Columns.Add("PROJECT_CODE");
            dtID.Columns.Add("OPERATION");

            int cib, rat, apc, apf, dupIVF, queried, reclassified, edited, deleted, verNotFiled, verFiled, eif, editRat;
            string user, user_name, trackingID, operation, projectCode;
            foreach (string file in files)
            {
                cib = 0;
                rat = 0;
                apc = 0;
                apf = 0;
                dupIVF = 0;
                queried = 0;
                reclassified = 0;
                edited = 0;
                deleted = 0;
                verNotFiled = 0;
                verFiled = 0;
                eif = 0;
                editRat = 0;
                trackingID = "";
                projectCode = "";
                operation = "";
                user = Path.GetExtension(file).Replace(".", "").Trim();
                string[] lines = File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    trackingID = line.Substring(0, 9);
                    projectCode = line.Substring(35, 5);
                    if (line.Substring(29, 1) == "3")
                    {
                        if (line.Substring(31, 1) == "0" || line.Substring(31, 1) == "1")
                        {
                            cib++;
                            operation = "CIB";
                        }
                        else if (line.Substring(31, 1) == "3")
                        {
                            dupIVF++;
                            operation = "DUPLICATED IVF";
                        }
                        else if (line.Substring(31, 1) == "4")
                        {
                            queried++;
                            operation = "QUERIED";
                        }
                        else if (line.Substring(31, 1) == "6")
                        {
                            reclassified++;
                            operation = "RECLASSIFIED";
                        }
                        else if (line.Substring(31, 1) == "7")
                        {
                            edited++;
                            operation = "EDITED";
                        }
                        else if (line.Substring(31, 1) == "8")
                        {
                            deleted++;
                            operation = "DELETED";
                        }
                        else if (line.Substring(31, 1) == "9")
                        {
                            editRat++;
                            operation = "EDITED PREVIOUSLY RATIFIED";
                        }
                    }
                    else if (line.Substring(29, 1) == "4")
                    {
                        verNotFiled++;
                        operation = "VER NOT FILED";
                    }
                    else if (line.Substring(29, 1) == "5")
                    {
                        verFiled++;
                        operation = "VER FILED";
                    }
                    else if (line.Substring(29, 1) == "6")
                    {
                        rat++;
                        operation = "RATIFIED";
                    }
                    else if (line.Substring(29, 1) == "8")
                    {
                        eif++;
                        operation = "EIF";
                    }
                    else if (line.Substring(29, 1) == "9")
                    {
                        if (line.Substring(31, 1) == "1")
                        {
                            apc++;
                            operation = "APC";
                        }
                        else if (line.Substring(31, 1) == "2")
                        {
                            apf++;
                            operation = "APF";
                        }
                    }
                    if(trackingID.Trim().Length == 9)
                        dtID.Rows.Add(user, trackingID, projectCode, operation);
                }
                user_name = (from s in users
                             where s.Substring(0, 3).Replace(" ", "B") == user
                             select s.Substring(12, 24).Trim()).FirstOrDefault();
                dt.Rows.Add(user, user_name, cib, verNotFiled, verFiled, rat, eif, apc, apf, dupIVF, queried, reclassified, edited, editRat, deleted);
                
            }
            List<DataTable> list = new List<DataTable>();
            list.Add(dt);
            list.Add(dtID);
            return list;
        }
        #endregion

        #region AP
        public DataTable GetIVFData(List<string> ids, string customer)
        {
            this.customerCode = customer;
            //string ivfFolder = @"U:\" + customer.sstem_code + @"\IVF";
            DataTable dt = new DataTable();
            dt.Columns.Add("TRACKING_ID");
            dt.Columns.Add("PREVIOUS_DATE");
            dt.Columns.Add("READING_DATE");
            dt.Columns.Add("DUE_DATE");
            dt.Columns.Add("GROSS_TOTAL");
            dt.Columns.Add("PROCESS TYPE");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("IVF_LINE");

            foreach (string id in ids)
            {
                string location = GetLocation(id);
                string ivfLine = GetIVFLine(id, location);

                DateTime previous = new DateTime(Convert.ToInt16("20" + ivfLine.Substring(275, 2)) , Convert.ToInt16(ivfLine.Substring(273,2)), Convert.ToInt16(ivfLine.Substring(271, 2)));
                DateTime reading = new DateTime(Convert.ToInt16("20" + ivfLine.Substring(21, 2)), Convert.ToInt16(ivfLine.Substring(19, 2)), Convert.ToInt16(ivfLine.Substring(17, 2)));
                DateTime due = new DateTime(Convert.ToInt16("20" + ivfLine.Substring(314, 2)), Convert.ToInt16(ivfLine.Substring(311, 2)), Convert.ToInt16(ivfLine.Substring(308, 2)));
                string gross = ivfLine.Substring(40, 10).Trim();
                string process = "";
                if (ivfLine.Substring(317, 1) == "L")
                    process = "LIVE AP";
                else if (ivfLine.Substring(317, 1) == "X")
                    process = "LIVE NO AP";
                else if (ivfLine.Substring(317, 1) == "H")
                    process = "HISTORIC";
                string status = "";
                if (process == "LIVE AP" && Convert.ToDouble(gross) > 0)
                    status = "OK";
                else
                    status = "CHECK";
                dt.Rows.Add(id, previous, reading, due, gross, process, status, ivfLine);
            }

            return dt;
        }

        private string GetLocation(string trackingID)
        {
            
            int sumBytes = 0;

            foreach (char c in trackingID.Substring(0, 8))
            {
                sumBytes = sumBytes + ((int)c);
            }
            int result = sumBytes % 26;
            result = 26 - result;
            result = 64 + result;
            char letter = ((char)result);
            string lixFolder = @"U:\" + customerCode + @"\ACH" + @"\" + letter + @"\" + trackingID.Substring(0, 8) + ".LI" + trackingID.Substring(8, 1);
            string[] lines = File.ReadAllLines(lixFolder);

            string location = lines[0].Substring(117, 8);
            return location;
        }

        private string GetIVFLine(string trackingID, string location)
        {
            try
            {
                string ivfFolder = @"U:\" + customerCode + @"\INV\" + location + ".IVF";
                string[] lines = File.ReadAllLines(ivfFolder);
                string line = (from l in lines
                               where l.Substring(296, 9) == trackingID
                               select l).FirstOrDefault();
                return line;
            }
            catch(Exception ex)
            {
                return "DOCUMENT NOT FOUND";
            }
        }
        #endregion
    }
}
