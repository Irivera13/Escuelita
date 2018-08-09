using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAMHS.DATA;
using SAMHS.DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Net.Mail;

namespace SAMHS.DAL.Metodos
{
    public class MUser : MBase, IUser
    {
        public List<User> ListUsers()
        {
            return _db.Select<User>();

        }

        public void AddUser(User user)
        {
            try
            {
                _db.Insert(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool UserLogin(int userId, string userPassword)
        {
            var userTOsearch = _db.Select<User>(x => x.User_id == userId && x.User_password == userPassword).FirstOrDefault();
            if (userTOsearch != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreatedUserAccountSentEmail(string email, string name)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("progra4545@gmail.com", "fidelitas123");
                MailMessage mm = new MailMessage("donotreply@domain.com", email, "Pm tool cuenta creada con exito", "Hola " + name + ", su cuenta fue creada con exito.");
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.Send(mm);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public User SearchUser(int userId)
        {
            try
            {
                return _db.Select<User>(x => x.User_id == userId).FirstOrDefault();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EditUser(User user)
        {
            try
            {
                _db.Update(user);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteUser(int userId)
        {
            try
            {
                _db.Delete<User>(x => x.User_id == userId);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
