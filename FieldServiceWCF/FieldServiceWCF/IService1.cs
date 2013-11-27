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
        [OperationContract]
        Field getField(int id);

        [OperationContract]
        List<Reservation> getAllReservations();

        [OperationContract]
        List<Field> getAllFields();
    }

    [DataContract]
    public class Field
    {
        [DataMember]
        public int fieldID { get; set; }
        [DataMember]
        public string fieldType { get; set; }
    }

    [DataContract]
    public class Name
    {
        public string name { get; set; }
    }

    [DataContract]
    public class Reservation
    {
        [DataMember]
        public int fieldID { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string date { get; set; }
    }
}
