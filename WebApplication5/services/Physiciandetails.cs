using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5;
using WebApplication5.DAL;
using WebApplication5.interfaces;

namespace WebApplication5.services
{ 
    public class Physiciandetails:Iphysiciandetails
    {
        //HospitalEntities db = new HospitalEntities();
        Physiciandb physiciandb;
        public  Physiciandetails ()
        {
          physiciandb = new Physiciandb();
        }
      public  IEnumerable<Physician> physician_list()
        {
            return (physiciandb.physician_list());
        }
    }
    }
