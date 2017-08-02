using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBMMS.DAL
{
    public class DALReports
    {
        private string _infoLCMServer;
        public DALReports()
        {
            //Em caso de mudança de senha, favor alterar também a variável de mesmo nome em DAL.Documents
            _infoLCMServer = "";
        }


        #region Productivity Report
        public DataTable DocumentsProcessedLastWeek(user u)
        {
            string opCode = "";

            if (u.id_team == 2)
            {
                opCode = "PROCESS";
            }
            if (u.id_team == 3)
            {
                opCode = "VERIFY";
            }

            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select teams.team_name, log_documents.op_code, date(log_documents.op_date) as date, count(log_documents.op_code) as total from teams inner join log_documents on teams.id = log_documents.op_user_team where log_documents.op_code = '" + opCode + "' and log_documents.op_user_team = " + u.id_team.ToString() + " and log_documents.op_date >= (CURDATE() - INTERVAL 7 DAY) group by log_documents.op_code, date; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable DocumentsReferredLastWeek(user u)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select teams.team_name, log_documents.op_code, date(log_documents.op_date) as date, count(log_documents.op_code) as total from teams inner join log_documents on teams.id = log_documents.op_user_team where log_documents.op_code = 'REFER' and log_documents.op_user_team = " + u.id_team.ToString() + " and log_documents.op_date >= (CURDATE() - INTERVAL 7 DAY) group by log_documents.op_code, date; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable DocumentsPending(user u)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select documents.referred, count(documents.tracking_id) as total from documents where documents.id_team = " + u.id_team + " and documents.finalized = 0 group by documents.referred; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable UserProductivitySummary(int idUser, string from, string to)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select users.user_name, teams.team_name, log_documents.op_code, count(log_documents.op_code) as total, time_format(sec_to_time(avg(time_to_sec(log_documents.action_time))),'%H:%i:%s') as average from users inner join teams on users.id_team = teams.id inner join log_documents on users.id_user = log_documents.op_user where (log_documents.op_date between '" + from + "' and '" + to + "') and(log_documents.op_code = 'PROCESS' or log_documents.op_code = 'REFER' or log_documents.op_code = 'VERIFY') and log_documents.op_user = " + idUser.ToString() + " group by users.user_name, log_documents.op_code; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable UserProductivityRangeProcess(int idUser, string from, string to)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select users.user_name, teams.team_name, log_documents.op_code, count(log_documents.op_code) as total, date(log_documents.op_date) as date from users inner join teams on users.id_team = teams.id inner join log_documents on users.id_user = log_documents.op_user where (log_documents.op_date between '" + from + "' and '" + to + "') and(log_documents.op_code = 'PROCESS' or log_documents.op_code = 'VERIFY') and log_documents.op_user = " + idUser + " group by users.user_name, log_documents.op_code, date; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable UserProductivityRangeRefer(int idUser, string from, string to)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select users.user_name, teams.team_name, log_documents.op_code, count(log_documents.op_code) as total, date(log_documents.op_date) as date from users inner join teams on users.id_team = teams.id inner join log_documents on users.id_user = log_documents.op_user where (log_documents.op_date between '" + from + "' and '" + to + "') and log_documents.op_code = 'REFER' and log_documents.op_user = " + idUser + " group by users.user_name, log_documents.op_code, date; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable UserProductivityByCustomer(int idUser, string from, string to)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select users.user_name, customers.customer_name, log_documents.op_code, count(log_documents.op_code) as total, date(log_documents.op_date) as date, time_format(sec_to_time(avg(time_to_sec(log_documents.action_time))),'%H:%i:%s') as average from users inner join log_documents on users.id_user = log_documents.op_user inner join documents on documents.tracking_id = log_documents.tracking_id inner join project_codes on documents.id_project_code = project_codes.project_code inner join customers on customers.id = project_codes.id_customer where (log_documents.op_date between '" + from + "' and '" + to + "') and (log_documents.op_code = 'PROCESS' or log_documents.op_code = 'REFER' or log_documents.op_code = 'VERIFY') and log_documents.op_user = " + idUser.ToString() + " group by users.user_name, log_documents.op_code, customers.customer_name, date order by date; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }
        #endregion

        #region Documents Received
        public DataTable DocumentsReceivedPerMonthTotal(string from, string to)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select date(op_date) as date, count(date(op_date)) as total from log_documents where op_code = 'UPLOAD' and(log_documents.op_date between " + from + " and " + to + ") group by date(op_date)", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable DocsReceivedByMonth(int year, int month)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select date(op_date) as date, count(date(op_date)) as total from log_documents where op_code = 'UPLOAD' and month(op_date) = '" + month.ToString() + "' and year(op_date) = '" + year.ToString() + "' group by day(op_date);", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        #endregion

        #region Customer's Dashboard
        public DataTable DocumentsPerTeam(int id_customer)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    string query = "select teams.team_name, count(documents.tracking_id) as total from documents " +
                                    "inner join project_codes on documents.id_project_code = project_codes.project_code " +
                                    "inner join customers on project_codes.id_customer = customers.id " +
                                    "inner join teams on documents.id_team = teams.id " +
                                    "where customers.id = " + id_customer + " and documents.finalized = 0 " +
                                    "group by teams.team_name order by total asc;";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable Aging(int id_customer)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    string query = "select customers.customer_name, documents.tracking_id, datediff(current_date(), log_documents.op_date) as aging from documents " +
                                    "inner join project_codes on documents.id_project_code = project_codes.project_code " +
                                    "inner join customers on project_codes.id_customer = customers.id " +
                                    "inner join log_documents on documents.tracking_id = log_documents.tracking_id " +
                                    "where customers.id = " + id_customer + " and documents.finalized = 0 and log_documents.op_code = 'UPLOAD' ";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable DocumentsDetails(int id_customer)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    string query = "select customers.customer_name, project_codes.project_code, project_codes.project_name, documents.tracking_id, documents.document_type, teams.team_name, date(log_documents.op_date) as date_upload, datediff(current_date(), log_documents.op_date) as aging from documents " +
                                    "inner join project_codes on documents.id_project_code = project_codes.project_code " +
                                    "inner join customers on project_codes.id_customer = customers.id " +
                                    "inner join teams on documents.id_team = teams.id " +
                                    "inner join log_documents on documents.tracking_id = log_documents.tracking_id " +
                                    "where customers.id = " + id_customer + " and documents.finalized = 0 and log_documents.op_code = 'UPLOAD'";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }
        #endregion Customer's Dashboard

        #region InfoLCM Reports

        public DataTable DocumentsStamped(DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_infoLCMServer))
            {
                string query = "select centrename as [Centre Name], username as [User], customername as [Customer], projectcode as [Project Code],tiffilename as [Document ID],filename as [File Name], a.timeupd as 'Date Stamped', datetime_loadedtoInfoLCM as 'Date Loaded', emailsubject as [Email Subject], h.EmailID as [Sender Email], doc_type as [Doc Type]  from tulog a " +
                                "inner join logins b on b.uid = a.iduser " +
                                "inner join useraccess c on c.uid = b.uid " +
                                "inner join centresearch d on d.csid = c.csid " +
                                "inner join centres e on e.cid = d.cid " +
                                "inner join documents f on f.doc_id = a.documenttype " +
                                "inner join customerinfo g on g.customercode = projectcode " +
                                "inner join TU_EmailDetails h on h.TU_email = a.TU_email " +
                                "where isuploaded = '1' and datetime_loadedtoInfoLCM > = '" + from.ToString("yyyy-MM-dd HH:mm:ss") + "' and datetime_loadedtoInfoLCM < '" + to.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                                "order by centrename, projectcode, username";

                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public DataTable DocumentHistory(string documentID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_infoLCMServer))
            {
                string query = "select InvoiceNo as [ID], InvoiceStatus as [Process], SUBSTRING(ITRFileName, 10, 3 ) AS [Operator Code], TimeUpd as [Time Upload], SSTEMfilelastupdated as [Last Updated] from itrattachment where SUBSTRING (invoiceno,1,8) = '" + documentID + "' order by invoiceno, timeupd";

                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }


        public DataTable Run(Action<int> update, DateTime from, DateTime to, List<string> projectcodes, string status)
        {
            string query = "";
            DataTable dt = new DataTable();
            if (status != "ALL" && status != "NONE")
            {
                status = "and i.SSTEM_Programcode = '" + status + "'";
            }
            else if (status == "NONE")
            {
                status = "and i.SSTEM_Programcode is null ";
            }
            else
            {
                status = "";
            }
            using (SqlConnection conn = new SqlConnection(_infoLCMServer))
            {
                conn.Open();

                int index = 0;
                foreach (string item in projectcodes)
                {
                    query = "select * from ( " +
                        "select i.invoiceno as [Tracking ID], d.doc_type as [Doc Type], i.ReceiptDate as [Receipt Date],d2.doc_type as [Received as], i.customercode as [Project Code], i.sstem_programcode[Current Status],it.invoicestatus, it.sstemfilelastupdated, di.duplicateof as [Duplicated of] from invoice i " +
                        "left join ITRAttachment it on i.invoiceno = it.invoiceno " +
                        "left join duplicateinvoice di on i.invoiceno = di.invoiceno " +
                        "inner join documents d on i.documentid = d.doc_id " +
                        "inner join tulog t on substring(i.invoiceno, 1, 8) = t.tiffilename " +
                        "inner join documents d2 on t.documenttype = d2.doc_id " +
                        "where i.timeupd between '" + from.ToString("yyyy-MM-dd HH:mm:ss") + "' and' " + to.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                        "and i.customercode = '" + item + "' " +
                        status +
                        "group by i.invoiceno,i.ReceiptDate, d.doc_type, i.customercode, i.sstem_programcode,  di.duplicateof, it.invoicestatus, it.sstemfilelastupdated, d2.doc_type " +
                        ") a " +
                        "pivot " +
                        "(max(sstemfilelastupdated) for [invoicestatus] in ([CIB],[VER],[WIB],[VAR],[APF],[EDT],[IST]))piv " +
                        "order by [Tracking ID];";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);
                        update(index);
                        index++;
                    }
                }
            }
            return dt;
        }

        public DataTable  OutstandingInvoices(DateTime from, DateTime to, List<string> projectcodes, string status)
        {
            string query = "";
            DataTable dt = new DataTable();
            if (status != "ALL" && status!="NONE")
            {
                status = "and i.SSTEM_Programcode = '" + status + "'";
            }
            else if(status =="NONE")
            {
                status = "and i.SSTEM_Programcode is null ";
            }
            else
            {
                status = "";
            }
            using (SqlConnection conn = new SqlConnection(_infoLCMServer))
            {
                conn.Open();

                foreach (string item in projectcodes)
                {
                    query = "select * from ( " +
                        "select i.invoiceno as [Tracking ID], d.doc_type as [Doc Type], i.ReceiptDate as [Receipt Date],d2.doc_type as [Received as], i.customercode as [Project Code], i.sstem_programcode[Current Status],it.invoicestatus, it.sstemfilelastupdated, di.duplicateof as [Duplicated of] from invoice i " +
                        "left join ITRAttachment it on i.invoiceno = it.invoiceno " +
                        "left join duplicateinvoice di on i.invoiceno = di.invoiceno " +
                        "inner join documents d on i.documentid = d.doc_id " +
                        "inner join tulog t on substring(i.invoiceno, 1, 8) = t.tiffilename " +
                        "inner join documents d2 on t.documenttype = d2.doc_id " +
                        "where i.timeupd between '" + from.ToString("yyyy-MM-dd HH:mm:ss") + "' and' " + to.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                        "and i.customercode = '" + item + "' " +
                        status +
                        "group by i.invoiceno,i.ReceiptDate, d.doc_type, i.customercode, i.sstem_programcode,  di.duplicateof, it.invoicestatus, it.sstemfilelastupdated, d2.doc_type " +
                        ") a " +
                        "pivot " +
                        "(max(sstemfilelastupdated) for [invoicestatus] in ([CIB],[VER],[WIB],[VAR],[APF],[EDT],[IST]))piv " +
                        "order by [Tracking ID];";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Get InfoLCM Brands information along with Project Codes and Project code of each Brand
        /// </summary>
        /// <returns>datatable</returns>
        public DataTable InfoProjectCodes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_infoLCMServer))
            {
                string query = "select ci.customername as [projectname], ci.customercode as [projectcode] from customerinfo ci " +
                                "where ci.customername is not null " + 
                                "order by ci.customername; ";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }

        /// <summary>
        /// Get InfoLCM Groups along with project code
        /// </summary>
        /// <returns>datatable</returns>
        public DataTable InfoGroups()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_infoLCMServer))
            {
                string query = "select cg.uid, cg.groupname, ci.customername as [projectname], ci.idcustomer, ci.customercode as projectcode from customergroup cg " +
                                "inner join customerinfo ci on cg.idcustomer = ci.idcustomer " +
                                "order by cg.groupname, ci.customername;";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }
        #endregion InfoLCM Reports
    }
}
