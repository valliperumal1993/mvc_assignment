using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.DAL
{
    public class Specialitydb
    {
        HospitalEntities db = new HospitalEntities();
        public IEnumerable<Speciality> Specialitynamelist()
        {
           return db.Specialities.ToList<Speciality>();
        }
    }
}