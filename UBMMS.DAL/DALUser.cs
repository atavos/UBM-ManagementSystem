using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBMMS.DAL
{
    public class DALUser
    {
        public DALUser()
        { }

        public user Select(user user)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                user u = db.users.Where(q => q.email == user.email && q.pass == user.pass).FirstOrDefault<user>();
                if (u != null)
                    return u;
                else
                    throw new Exception("Invalid Email or Password");
            }
        }

        public List<user> SelectUsersByTeam(int idTeam)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                List<user> users = (from u in db.users
                                    where u.id_team == idTeam
                                    select u).ToList();
                return users;
            }
        }
        public void CreateUser(user user)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                if (CheckforExistingEmail(user))
                {
                    throw new Exception("Hey, this email is already on the database!\nYou don't need to create that user");
                }      
                else
                {
                    db.users.Add(user);
                    db.SaveChanges();
                }
            }
        }

        public void UpdateUser(user user)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                user u = db.users.Where(q => q.email == user.email).FirstOrDefault();

                u.user_name = user.user_name;
                u.pass = user.pass;

                db.SaveChanges();
            }
        }

        public bool CheckforExistingEmail(user user)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                user u = db.users.Where(q => q.email == user.email).FirstOrDefault<user>();
                if (u == null)
                    return false;
                else
                    return true;
            }
        }
        public user GetUserByEmail (user user)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                user u = db.users.Where(q => q.email == user.email).FirstOrDefault<user>();
                return u;
            }
        }
    }
}
