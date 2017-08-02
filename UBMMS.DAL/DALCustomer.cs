using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using MySql.Data.MySqlClient;

namespace UBMMS.DAL
{
    public class DALCustomer
    {
        public DALCustomer()
        {}

        /// <summary>
        /// get customer, project codes and documents from the db in lazy load
        /// </summary>
        /// <returns></returns>
        public List<customer> SelectAll()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                var result = db.customers
                             .Include(p => p.project_codes)
                             .OrderBy(c=>c.customer_name)
                             .ToList();
                return result;
                             
            }
        }

        /// <summary>
        /// Get Customers and project codes in eager loading
        /// </summary>
        /// <returns></returns>
        public List<customer> GetCustomersProjects()
        {
            ubmmsEntities db = new ubmmsEntities();
            var result = db.customers
                .Include(p => p.project_codes)
                .OrderBy(c => c.customer_name)
                .ToList();
            return result;
        }

        /// <summary>
        /// Obtem todas as informações de clientes ativos
        /// </summary>
        /// <returns>lista customer </customer></returns>
        public List<customer> SelectAllforActiveCustomers()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                var result = db.customers
                    .Include(p => p.project_codes).Where(c => c.enabled == true)
                    .OrderBy(c => c.customer_name)
                    .ToList();
                return result;
            }
                
        }

        public DataTable CustomerWithPendingDocuments(user u, bool queue)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                int q = 0;
                if (queue)
                    q = 1;
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {

                    using (MySqlCommand cmd = new MySqlCommand("select customers.customer_name, count(documents.tracking_id) as total from customers inner join project_codes on customers.id = project_codes.id_customer inner join documents on project_codes.project_code = documents.id_project_code where documents.id_team = " + u.id_team + " and documents.finalized = 0 and documents.id_user is null and documents.referred = " + q + " group by customers.customer_name; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        /// <summary>
        /// Obtem a quantidade de documentos por clientes ativos para o time do usuário logado
        /// </summary>
        /// <param name="u"></param>
        /// <returns>datatable</returns>
        public DataTable DocumentsTeam(user u)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(db.Database.Connection.ConnectionString))
                {

                    using (MySqlCommand cmd = new MySqlCommand("select customers.customer_name, count(documents.tracking_id) as total from customers inner join project_codes on customers.id = project_codes.id_customer inner join documents on project_codes.project_code = documents.id_project_code where documents.id_team = " + u.id_team + " and documents.finalized = 0 and documents.id_user is null and customers.enabled = true group by customers.customer_name order by total DESC; ", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.CommandType = CommandType.Text;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        /// <summary>
        /// Cria um cliente no banco
        /// </summary>
        /// <param name="customer">EF customer</param>
        public void CreateNewCustomer(customer customer)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                customer c = db.customers.Where(x => x.sstem_code == customer.sstem_code).FirstOrDefault();
                if(c==null)
                {
                    db.customers.Add(customer);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("This customer Code already exists on the Database. Please review the information");
                }
                
            }
        }

        /// <summary>
        /// Atualiza informações de clientes. 
        /// </summary>
        /// <param name="customer">EF customer</param>
        public void UpdateCustomer(customer customer)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                customer c = db.customers.Where(code => code.id == customer.id).FirstOrDefault();

                c.customer_name = customer.customer_name;
                c.enabled = customer.enabled;

                db.SaveChanges();
            }
        }

        /// <summary>
        /// Cria um novo Project Code no Banco
        /// </summary>
        /// <param name="project">EF project_codes</param>
        public void CreateNewProjectCode(project_codes project)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                project_codes p = db.project_codes.Where(x => x.project_code == project.project_code).FirstOrDefault();
                if(p==null)
                {
                    db.project_codes.Add(project);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("this project code already exists on the Database. Please review the information");
                }
            }
        }

        /// <summary>
        /// Atualiza um Project Code existente
        /// </summary>
        /// <param name="project">EF project_codes</param>
        public void UpdateProjectCode(project_codes project)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                project_codes p = db.project_codes.Where(code => code.project_code == project.project_code).FirstOrDefault();

                p.project_name = project.project_name;
                p.ap_enabled = project.ap_enabled;
                p.enabled = project.enabled;

                db.SaveChanges();
            }
        }
    }
}
