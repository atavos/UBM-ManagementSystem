using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UBMMS.DAL
{
    public class DALDashboard
    {
        public DALDashboard()
        { }

        public DataTable DocsReceivedYear()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select date(op_date), count(date(op_date)) as total from log_documents where op_code = 'UPLOAD' group by year(op_date)", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable DocsReceivedByYear(int year)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select date(op_date) as date, count(date(op_date)) as total from log_documents where op_code = 'UPLOAD' and year(op_date) = '"+ year.ToString() + "' group by month(op_date);", connection))
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
                    using (MySqlCommand cmd = new MySqlCommand("select date(op_date) as date, count(date(op_date)) as total from log_documents where op_code = 'UPLOAD' and month(op_date) = '" + month.ToString() + "' and year(op_date) = '"+ year.ToString() +"' group by day(op_date);", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable DocsReceivedByDayCustomer(int year, int month, int day)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    string date = year.ToString() + "-" + month.ToString().PadLeft(2,'0') + "-" + day.ToString().PadLeft(2,'0');
                    using (MySqlCommand cmd = new MySqlCommand("select customers.customer_name, project_codes.project_name, count(documents.tracking_id) as total, date(log_documents.op_date) as date from customers inner join project_codes on customers.id = project_codes.id_customer inner join documents on project_codes.project_code = documents.id_project_code inner join log_documents on documents.tracking_id = log_documents.tracking_id where log_documents.op_code = 'UPLOAD' and log_documents.op_date >= '"+ date + " 00:00:00' and log_documents.op_date <= '" + date + " 23:59:99' group by customers.customer_name; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable TotalDocs()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    
                    using (MySqlCommand cmd = new MySqlCommand("select count(log_documents.tracking_id) as total from log_documents where log_documents.op_code = 'UPLOAD'", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable TotalDocsToday()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    string date = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString().PadLeft(2,'0') + "-" + DateTime.Now.Day.ToString().PadLeft(2,'0');
                    using (MySqlCommand cmd = new MySqlCommand("select count(log_documents.tracking_id) as total from log_documents where op_code = 'UPLOAD' and op_date >= '"+date+"';", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable TotaBacklog()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select count(documents.tracking_id) as total from documents where documents.finalized = 0;", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable TotalProcessToday()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    string date = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "-" + DateTime.Now.Day.ToString().PadLeft(2, '0');
                    using (MySqlCommand cmd = new MySqlCommand("select count(documents.tracking_id) as total from documents inner join log_documents on documents.tracking_id = log_documents.tracking_id where log_documents.op_code = 'VERIFY' and log_documents.op_date >= '" + date + "';", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable TotalProcess()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    string date = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString().PadLeft(2,'0') + "-" + DateTime.Now.Day.ToString().PadLeft(2,'0');
                    using (MySqlCommand cmd = new MySqlCommand("select count(documents.tracking_id) as total from documents where documents.finalized = 1;", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable TotalBacklogPerTeam()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    
                    using (MySqlCommand cmd = new MySqlCommand("select teams.team_name, count(documents.tracking_id) as total from teams inner join documents on teams.id = documents.id_team where documents.finalized = 0 group by teams.team_name order by total asc;", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable UserProductivityToday()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    string date = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "-" + DateTime.Now.Day.ToString().PadLeft(2, '0');
                    using (MySqlCommand cmd = new MySqlCommand("select users.user_name, teams.team_name, log_documents.op_code, count(log_documents.op_code) as total, time_format(sec_to_time(avg(time_to_sec(log_documents.action_time))),'%H:%i:%s') as average from users inner join teams on users.id_team = teams.id inner join log_documents on users.id_user = log_documents.op_user where log_documents.op_date >= '" + date + "' and(log_documents.op_code = 'PROCESS' or log_documents.op_code = 'REFER' or log_documents.op_code = 'VERIFY') group by users.user_name, log_documents.op_code; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable UserAVGToday()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {
                    string date = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "-" + DateTime.Now.Day.ToString().PadLeft(2, '0');
                    using (MySqlCommand cmd = new MySqlCommand("select users.user_name, customers.customer_name, log_documents.op_code, count(log_documents.op_code) as total, time_format(sec_to_time(avg(time_to_sec(log_documents.action_time))),'%H:%i:%s') as average from users inner join log_documents on users.id_user = log_documents.op_user inner join documents on documents.tracking_id = log_documents.tracking_id inner join project_codes on documents.id_project_code = project_codes.project_code inner join customers on customers.id = project_codes.id_customer where log_documents.op_date >= '" + date + "' and(log_documents.op_code = 'PROCESS' or log_documents.op_code = 'REFER' or log_documents.op_code = 'VERIFY') group by users.user_name, log_documents.op_code, customers.customer_name;", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }
    }
}
