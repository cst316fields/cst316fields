using System;
using System.Collections.Generic;
using System.Data;
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
        DataTable getAllReservations();

        [OperationContract]
        DataTable getAllFields();
    }
    [DataContract]
    public class User
    {
        [DataMember]
        public string user { get; set; }
        [DataMember]
        public string password { get; set; }
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
    public class Person
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int phone { get; set; }
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
