using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserManager
    {
        Repository<User> repouser = new Repository<User>();
        public List<User> GetAll()
        {
            return repouser.List();
        }

        public User GetUserById(int id)
        {
            User User = repouser.List().Where(p => p.UserId == id).FirstOrDefault();
            return User;
        }

    }
}
