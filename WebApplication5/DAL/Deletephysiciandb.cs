using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.DAL
{
    public class Deletephysiciandb
    {
        HospitalEntities db = new HospitalEntities();
            public void delete(String id)
        {
            Physician physician = db.Physicians.Find(id);
            db.Physicians.Remove(physician);
            db.SaveChanges();
        }
    }
}