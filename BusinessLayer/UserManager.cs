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

        public int DeleteUser(int id)
        {
            User user = repouser.Find(p => p.UserId == id);
            return repouser.Delete(user);
        }

        public int UpdateUser(User u)
        {
            User user = repouser.Find(p => p.UserId == u.UserId);
            user.Username = u.Username;
            user.Name = u.Name;
            user.Surname = u.Surname;
            user.Password = u.Password;
            user.Mail = u.Mail;
            user.ProfileImg = u.ProfileImg;
            user.RegisterDate = u.RegisterDate;
            return repouser.Update(user);

        }
    }
}
