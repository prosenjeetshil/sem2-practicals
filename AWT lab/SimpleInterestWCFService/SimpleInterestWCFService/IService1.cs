using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SimpleInterestWCFService
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double CalculateSimpleInterest(double principal, double rate, double time);
    }

}
