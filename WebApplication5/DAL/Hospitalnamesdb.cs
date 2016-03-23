using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.DAL
{
    public class Hospitalnamesdb
    {
        HospitalEntities db = new HospitalEntities();
        public IEnumerable<Hospital> hospitalnamelist()
        {
            return db.Hospitals.ToList<Hospital>();
        }
    }
}