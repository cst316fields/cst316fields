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
            using (fieldsEntities context = new fieldsEntities())
            {
                var fieldE = (from p in context.FieldEntities where p.Id==id select p).First();

                return translateFieldEntity(fieldE);
            }
        }

        public DataTable getAllReservations()
        {
            DataTable dt = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {
                List<Reservation> listR = new List<Reservation>();
                foreach(var v in context.ReservationEntities)
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
            DataTable dt = new DataTable();
            using (fieldsEntities context = new fieldsEntities())
            {
                List<Field> l = new List<Field>();
                foreach(var r in context.FieldEntities)
                {
                    l.Add(translateFieldEntity(r));
                }
                int i = 0;

                foreach (var str in l)
                {
                    dt.Rows[i][0] = str.ToString();
                    i++;
                }
                return dt;
            }
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
            reservation.date = r.date;
            return reservation;
        }
    }
}
