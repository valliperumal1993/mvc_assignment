using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.DAL
{
    public class Addphysiciandb
    {
        HospitalEntities db = new HospitalEntities();
        public void SavePhysiciandb(Physician physician)
        {
            db.Physicians.Add(physician);
            db.SaveChanges();
        }
    }
}