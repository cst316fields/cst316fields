using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FieldsProject
{
    [ServiceContract]
    public interface FieldService
    {  
        /// <summary>
        /// Returns a single field with attributes Field.fieldId, Field.fieldType
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Field</returns>
        [OperationContract]
        Field getField(int id);

        /// <summary>
        /// Returns a table of all fields of given type
        /// </summary>
        /// <param name="fieldType"></param>
        /// <returns>DataTable</returns>
        [OperationContract]
        DataTable getFields(string fieldType);

        /// <summary>
        /// Returns the entire Field table
        /// </summary>
        /// <returns>DataTable</returns>
        [OperationContract]
        DataTable getAllFields();

        /// <summary>
        /// Add a field to the Field table
        /// </summary>
        /// <param name="fieldId"></param>
        /// <param name="type"></param>
        [OperationContract]
        void addField(int fieldId, string type);
        
        /// <summary>
        /// Returns all users with given phone number
        /// </summary>
        /// <param name="phoneNum"></param>
        /// <returns>DataTable</returns>
        [OperationContract]
        DataTable getPersonFromPhoneNum(string phoneNum);

        /// <summary>
        /// Returns all users with given address
        /// </summary>
        /// <param name="address"></param>
        /// <returns>DataTable</returns>
        [OperationContract]
        DataTable getPersonFromAddress(string address);

        /// <summary>
        /// Returns user with given name, access attributes with Person.name, Person.phone, Person.address
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Person</returns>
        [OperationContract]
        Person getPersonFromName(string name);

        /// <summary>
        /// Returns the entire Person table
        /// </summary>
        /// <returns>DataTable</returns>
        [OperationContract]
        DataTable getAllPeople();

        /// <summary>
        /// Adds a person to Person table.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        [OperationContract]
        DataTable addPerson(string name, string phone, string address);

        /// <summary>
        /// Returns all reservations on a certain date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>DataTable</returns>
        [OperationContract]
        DataTable getReservationsByDate(string date);

        /// <summary>
        /// Returns all reservations make by given person
        /// </summary>
        /// <param name="name"></param>
        /// <returns>DataTable</returns>
        [OperationContract]
        DataTable getReservationsByPerson(string name);

        /// <summary>
        /// Returns all reservations for given fieldId number.
        /// </summary>
        /// <param name="fieldId"></param>
        /// <returns>DataTable</returns>
        [OperationContract]
        DataTable getReservationsByField(int fieldId);

        /// <summary>
        /// Returns the entire Reservation table
        /// </summary>
        /// <returns>DataTable</returns>
        [OperationContract]
        DataTable getAllReservations();

        /// <summary>
        /// Adds a reservation.
        /// </summary>
        /// <param name="fieldId"></param>
        /// <param name="name"></param>
        /// <param name="date"></param>
        [OperationContract]
        void addReservation(int fieldId, string name, string date);

        /// <summary>
        /// Athenticate user name and password.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>true if user exists, false if user does not exist</returns>
        [OperationContract]
        bool authenticateUser(string userName, string password);

        /// <summary>
        /// Adds a new user, and adds the person.  User names are unique.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        [OperationContract]
        void createUser(string userName, string password, string phoneNum, string address);
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
        public string phone { get; set; }
        [DataMember]
        public string address { get; set; }
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

    [DataContract]
    public class User
    {
        [DataMember]
        public string user { get; set; }
        [DataMember]
        public string password { get; set; }
    }
}