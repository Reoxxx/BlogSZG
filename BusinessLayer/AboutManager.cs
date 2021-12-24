using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AboutManager
    {
        Repository<About> repoabout = new Repository<About>();
        public List<About> GetAll()
        {
            return repoabout.List();
        }

        public About GetAboutById(int id)
        {
            About about = repoabout.List().Where(p => p.AboutId == id).FirstOrDefault();
            return about;
        }

    }
}
