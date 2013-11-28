using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.Common;

namespace FieldServiceWCF
{
    public class Service1 : FieldService
    {
        public Field getField(int id)
        {
            
            using (fieldsData context = new fieldsData())
            {
                var fieldE = (from p in context.FieldEs where p.Id==id select p).First();

                return translateFieldEntity(fieldE);
            }
        }

        public DataTable getAllReservations()
        {
            DataTable dt = new DataTable();
            using (fieldsData context = new fieldsData())
            {
                List<Reservation> listR = new List<Reservation>();
                foreach(var v in context.ReservationEs)
                {
                    listR.Add(translateReservationEntity(v));
                }
                int i = 0;
                
                foreach (var str in listR)
                {
                    dt.Rows[i][0] = str.ToString();
                    i++;
                }
                return dt;
            }

        }

        public DataTable getAllFields()
        {
            var table = new DataTable();
            using (fieldsData context = new fieldsData())
            {

                //List<Field> l = new List<Field>();
                //foreach (var r in context.FieldEntities)
                //{
                //   l.Add(translateFieldEntity(r));
                //}
                //int i = 0;


                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Type", typeof(string));

                foreach (var entity in context.FieldEs)
                {
                    var row = table.NewRow();
                    row["Id"] = entity.Id;
                    row["Type"] = entity.Type;
                    table.Rows.Add(row);
                }
            }
              return table;
        }

        private Field translateFieldEntity( FieldE fieldEntity)
        {
            Field field = new Field();
            field.fieldID = fieldEntity.Id;
            field.fieldType = fieldEntity.Type;
            return field;
        }

        private Reservation translateReservationEntity(ReservationE r)
        {
            Reservation reservation = new Reservation();
            reservation.fieldID = r.Id;
            reservation.name = r.name;
            reservation.date = Convert.ToString(r.date);
            return reservation;
        }
    }
}
