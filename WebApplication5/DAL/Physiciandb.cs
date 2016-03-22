using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.DAL
{
    public class Physiciandb
    {
        HospitalEntities db = new HospitalEntities();
        public IEnumerable<Physician> physician_list()
        {
            return (db.Physicians);
        }
       
    }
}