using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FieldServiceWCF
{
    [ServiceContract]
    public interface FieldService
    {
        [DataMember]
        public int fieldID { get; set; }

        [DataMember]
        public string fieldType { get; set; }
    }
}
