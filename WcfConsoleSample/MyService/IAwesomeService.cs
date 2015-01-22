using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAwesomeService" in both code and config file together.
    [ServiceContract]
    public interface IAwesomeService
    {
        [OperationContract]
        string HelloWorld();
    }
}
