using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RefWCF;

namespace RefWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        Student GetStudentById(int value);

        
        // TODO: Add your service operations here
    }

    
    
}
