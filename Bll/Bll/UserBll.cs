using LetsLearnCzech.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsLearnCzech.Bll
{
    /// <summary>Contains BLL methods related to <see cref="User"/>.</summary>
    public class UserBll
    {
        public User GetUserById(int id)
        {
            using (var bll = new BllContext())
            {
                return bll.Users.Where(u => u.UserId == id).FirstOrDefault();
            }
        }

        public User GetUserByName(string name)
        {
            using (var bll = new BllContext())
            {
                return bll.Users.Where(u => u.UserName == name).FirstOrDefault();
            }
        }

        public void AddUser(string userName)
        {
            using (var bll = new BllContext())
            {
                User user = new User()
                {
                    UserName = userName
                };
                bll.Users.Add(user);
                bll.SaveChanges();
            }
        }

    }
}
