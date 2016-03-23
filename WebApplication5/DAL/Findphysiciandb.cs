using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.DAL
{
    public class Findphysiciandb
    {
        HospitalEntities db = new HospitalEntities();

        public  Physician findphysician(int id)
        {
            Physician physician = db.Physicians.Find(id);
            return physician;
        }
    }
}