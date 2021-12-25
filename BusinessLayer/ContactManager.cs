using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ContactManager
    {
        Repository<Contact> repocontact = new Repository<Contact>();
        public List<Contact> GetAll()
        {
            return repocontact.List();
        }

        public int AddContact(Contact c)
        {
            if (c.Name.Length < 3 || c.Mail.Length < 10 || c.Subject.Length < 3 || c.Text.Length < 10 )
            {
                return -1;
            }
            return repocontact.Insert(c);
        }

        /*public Contact GetContactById(int id)
        {
            Contact Contact = repocontact.List().Where(p => p.ContactId == id).FirstOrDefault();
            return Contact;
        }*/

    }
}
