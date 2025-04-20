using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _27_UserWCFService
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        User GetUserDetails(int userId);

        [OperationContract]
        bool UpdateUserDetails(User user);
    }
}
