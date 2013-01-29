using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace RefWCF
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int StudentID;

        [DataMember]
        public string FirstName;

        [DataMember]
        public string LastName;

        [DataMember]
        public int Age;
        
    }
}
