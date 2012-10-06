using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Greg.RestLearning.ServiceContracts
{
    [ServiceContract]
    public interface ITestService
    {
        [WebGet(UriTemplate = "/test")]
        [OperationContract]
        string Test();
    }
}
