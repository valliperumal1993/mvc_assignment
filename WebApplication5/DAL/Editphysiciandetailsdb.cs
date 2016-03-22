using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication5.DAL
{
    public class Editphysiciandetailsdb
    {
        HospitalEntities db = new HospitalEntities();
        public void Editphysiciandb(Physician physician)
        {
            db.Entry(physician).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}