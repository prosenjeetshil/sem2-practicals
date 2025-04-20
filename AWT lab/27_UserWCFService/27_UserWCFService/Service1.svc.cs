using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _27_UserWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IUserService
    {
        private UserDBEntities db = new UserDBEntities(); // EF context

        public User GetUserDetails(int userId)
        {
            var userEntity = db.Users.SingleOrDefault(u => u.UserId == userId);
            if (userEntity != null)
            {
                return new User
                {
                    UserId = userEntity.UserId,
                    FirstName = userEntity.FirstName,
                    LastName = userEntity.LastName,
                    Email = userEntity.Email,
                    Age = userEntity.Age
                };
            }
            return null;
        }

        public bool UpdateUserDetails(User user)
        {
            var existing = db.Users.SingleOrDefault(u => u.UserId == user.UserId);
            if (existing != null)
            {
                existing.FirstName = user.FirstName;
                existing.LastName = user.LastName;
                existing.Email = user.Email;
                existing.Age = user.Age;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }

}
