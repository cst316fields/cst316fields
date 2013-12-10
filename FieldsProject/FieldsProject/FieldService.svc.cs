//comment to test github 

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
                table.Columns.Add("Date", typeof(DateTime));
                foreach (var res in context.ReservationEntities)
                {
                    var row = table.NewRow();
                    row["Field #"] = res.Id;
                    row["Person"] = res.name;
                    row["Date"] = res.date;
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
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Address", typeof(string));
                table.Columns.Add("Description", typeof(string));
                foreach (var entity in context.FieldEntities)
                {
                    var row = table.NewRow();
                    row["Id"] = entity.Id;
                    row["Type"] = entity.type;
                    row["Name"] = entity.name;
                    row["Address"] = entity.address;
                    row["Description"] = entity.description;
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

        public DataTable getReservationsByDate(DateTime date)
        {
            DataTable table = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {
                table.Columns.Add("Field #", typeof(int));
                table.Columns.Add("Field Name", typeof(string));
                table.Columns.Add("8:00am to 10:00am", typeof(string));
                table.Columns.Add("10:00am to 12:00pm", typeof(string));
                table.Columns.Add("12:00pm to 2:00pm", typeof(string));
                table.Columns.Add("2:00pm to 4:00pm", typeof(string));
                table.Columns.Add("4:00pm to 6:00pm", typeof(string));
                table.Columns.Add("6:00pm to 8:00pm", typeof(string));
                table.Columns.Add("8:00pm to 10:00pm", typeof(string));
                foreach (var field in context.FieldEntities)
                {
                    var row = table.NewRow();
                    row["Field #"] = field.Id;
                    row["Field Name"] = field.name;
                    row["8:00am to 10:00am"] = "Unreserved";
                    row["10:00am to 12:00pm"] = "Unreserved";
                    row["12:00pm to 2:00pm"] = "Unreserved";
                    row["2:00pm to 4:00pm"] = "Unreserved";
                    row["4:00pm to 6:00pm"] = "Unreserved";
                    row["6:00pm to 8:00pm"] = "Unreserved";
                    row["8:00pm to 10:00pm"] = "Unreserved";
                    foreach (var res in (from r in context.ReservationEntities where r.Id == field.Id select r))
                    {
                        if (res.date.Month == date.Month && res.date.Day == date.Day)
                        {
                            switch (res.date.Hour)
                            {
                                case 8:
                                    row["8:00am to 10:00am"] = res.name;
                                    break;
                                case 10:
                                    row["10:00am to 12:00pm"] = res.name;
                                    break;
                                case 12:
                                    row["12:00pm to 2:00pm"] = res.name;
                                    break;
                                case 14:
                                    row["2:00pm to 4:00pm"] = res.name;
                                    break;
                                case 16:
                                    row["4:00pm to 6:00pm"] = res.name;
                                    break;
                                case 18:
                                    row["6:00pm to 8:00pm"] = res.name;
                                    break;
                                case 20:
                                    row["8:00pm to 10:00pm"] = res.name;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public DataTable getReservationsByPerson(string name)
        {
            DataTable table = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {
                int count = 1;
                table.Columns.Add("Select", typeof(int));
                table.Columns.Add("Field #", typeof(int));
                table.Columns.Add("Field Name", typeof(string));
                table.Columns.Add("Address", typeof(string));
                table.Columns.Add("Date and time", typeof(DateTime));
                foreach (var res in (from r in context.ReservationEntities where r.name == name select r))
                {
                    if (res.date < DateTime.Now)
                    {
                        deleteReservation(res.Id, res.name, res.date);
                    }
                    else
                    {
                        var row = table.NewRow();
                        var field = (from f in context.FieldEntities where f.Id == res.Id select f).First();
                        row["Select"] = count;
                        row["Field Name"] = field.name;
                        row["Address"] = field.address;
                        row["Field #"] = res.Id;
                        row["Date and time"] = res.date;
                        table.Rows.Add(row);
                        count++;
                    }
                }
            }
            return table;
        }

        public DataTable getReservationsByField(int fieldId)
        {
            DataTable table = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {
                table.Columns.Add("Field #", typeof(int));
                table.Columns.Add("Field Name", typeof(string));
                table.Columns.Add("Address", typeof(string));
                table.Columns.Add("Date and time", typeof(string));
                foreach (var res in (from r in context.ReservationEntities where r.Id == fieldId select r))
                {
                    var row = table.NewRow();
                    var field = (from f in context.FieldEntities where f.Id == res.Id select f).First();
                    row["Field Name"] = field.name;
                    row["Address"] = field.address;
                    row["Field #"] = res.Id;
                    row["Date and time"] = res.date.Date.ToString();
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public bool addReservation(int fieldId, string name, DateTime date)
        {
            bool success = true;
            ReservationEntity res = new ReservationEntity();
            res.Id = fieldId;
            res.name = name;
            res.date = date;
            try
            {
                using (fieldsEntities context = new fieldsEntities())
                {
                    context.ReservationEntities.Add(res);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                success = false;
            }
            return success;
        }

        public bool authenticateUser(string userName, string password)
        {
            bool authenticated = false;
            if (userName.Length > 0 && password.Length > 0)
            {
                using (fieldsEntities context = new fieldsEntities())
                {
                    foreach (var user in (from u in context.UserEntities where u.username == userName select u))
                    {
                        if (user.password == password)
                            authenticated = true;
                    }
                }
            }
            return authenticated;
        }

        public bool createUser(string userName, string password, string phoneNum, string address)
        {
            bool success = true;
            UserEntity user = new UserEntity();
            PersonEntity person = new PersonEntity();
            user.username = userName;
            user.password = password;
            person.name = userName;
            person.phone = phoneNum;
            person.address = address;
            using (fieldsEntities context = new fieldsEntities())
            {
                try
                {
                    {
                        context.UserEntities.Add(user);
                        context.PersonEntities.Add(person);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    success = false;
                }

            }
            return success;
        }

        public bool deleteReservation(int fieldId, string Pname, DateTime Pdate)
        {
            bool success = true;

            using (fieldsEntities context = new fieldsEntities())
            {
                try
                {
                    foreach (var res in (from r in context.ReservationEntities where r.Id == fieldId && r.name == Pname &&
                              r.date.Month == Pdate.Month && r.date.Year == Pdate.Year && r.date.Day == Pdate.Day && r.date.Hour == Pdate.Hour select r))
                    {
                        context.ReservationEntities.Remove(res);
                    }
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    success = false;
                }
            }
            return success;
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
            reservation.date = Convert.ToDateTime(r.date);
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

        private User translateUserEntity(UserEntity u)
        {
            User user = new User();
            user.user = u.username;
            user.password = u.password;
            return user;
        }
    }
}
