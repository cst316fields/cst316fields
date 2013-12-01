using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.Common;
using FieldsProject;


namespace Service1
{
    public class DataService : FieldService
    {
        public Field getField(int id)
        {
            using (fieldsEntities context = new fieldsEntities())
            {
                var fieldE = (from p in context.FieldEntities where p.Id==id select p).First();
                return translateFieldEntity(fieldE);
            }
        }

        public DataTable getAllReservations()
        {
            DataTable table = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {
                table.Columns.Add("Field #", typeof(int));
                table.Columns.Add("Person", typeof(string));
                table.Columns.Add("Date", typeof(string));
                foreach (var res in context.ReservationEntities)
                {
                    var row = table.NewRow();
                    row["Field #"] = res.Id;
                    row["Person"] = res.name;
                    row["Date"] = res.date.ToString();
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public DataTable getAllFields()
        {
            var table = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {

                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Type", typeof(string));
                foreach (var entity in context.FieldEntities)
                {
                    var row = table.NewRow();
                    row["Id"] = entity.Id;
                    row["Type"] = entity.type;
                    table.Rows.Add(row);
                }
            }
              return table;
        }

        public DataTable getFields(string fieldType)
        {
            var table = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Type", typeof(string));
                var fieldE = (from p in context.FieldEntities where p.type == fieldType select p);
                foreach (var entity in fieldE)
                {
                    var row = table.NewRow();
                    row["Id"] = entity.Id;
                    row["Type"] = entity.type;
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public void addField(int fieldId, string type)
        {
            throw new NotImplementedException();
        }

        public DataTable getPersonFromPhoneNum(string phoneNum)
        {
            var table = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Phone", typeof(string));
                table.Columns.Add("Address", typeof(string));
                var fieldE = (from p in context.PersonEntities where p.phone == phoneNum select p);
                foreach (var p in fieldE)
                {
                    var row = table.NewRow();
                    row["Name"] = p.name;
                    row["Phone"] = p.phone;
                    row["Address"] = p.address;
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public DataTable getPersonFromAddress(string address)
        {
            var table = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Phone", typeof(string));
                table.Columns.Add("Address", typeof(string));
                var fieldP = (from p in context.PersonEntities where p.address == address select p);
                foreach (var per in fieldP)
                {
                    var row = table.NewRow();
                    row["Name"] = per.name;
                    row["Phone"] = per.phone;
                    row["Address"] = per.address;
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public Person getPersonFromName(string name)
        {
            using (fieldsEntities context = new fieldsEntities())
            {
                var fieldE = (from p in context.PersonEntities where p.name == name select p).First();
                return translatePersonEntity(fieldE);
            }
        }

        public DataTable getAllPeople()
        {
            var table = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Phone", typeof(string));
                table.Columns.Add("Address", typeof(string));
                foreach (var p in context.PersonEntities)
                {
                    var row = table.NewRow();
                    row["Name"] = p.name;
                    row["Phone"] = p.phone;
                    row["Address"] = p.address;
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public DataTable addPerson(string name, string phone, string address)
        {
            throw new NotImplementedException();
        }

        public DataTable getReservationsByDate(string date)
        {
            throw new NotImplementedException();
        }

        public DataTable getReservationsByPerson(string name)
        {
            throw new NotImplementedException();
        }

        public DataTable getReservationsByField(int fieldId)
        {
            throw new NotImplementedException();
        }

        public void addReservation(int fieldId, string name, string date)
        {
            throw new NotImplementedException();
        }

        public bool authenticateUser(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public void createUser(string userName, string password, string phoneNum, string address)
        {
            throw new NotImplementedException();
        }

        private Field translateFieldEntity( FieldEntity fieldEntity)
        {
            Field field = new Field();
            field.fieldID = fieldEntity.Id;
            field.fieldType = fieldEntity.type;
            return field;
        }

        private Reservation translateReservationEntity(ReservationEntity r)
        {
            Reservation reservation = new Reservation();
            reservation.fieldID = r.Id;
            reservation.name = r.name;
            reservation.date = Convert.ToString(r.date);
            return reservation;
        }

        private Person translatePersonEntity(PersonEntity p)
        {
            Person person = new Person();
            person.name = p.name;
            person.phone = p.phone;
            person.address = p.address;
            return person;
        }
    }
}
