using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5;
using WebApplication5.DAL;
using WebApplication5.interfaces;


namespace WebApplication5.services
{
    public class showphysiciandetails:Ishowphysiciandetails
    {
        Findphysiciandb findphysiciandb;
            public showphysiciandetails()
        {
            findphysiciandb = new Findphysiciandb();
        }
            public Physician showdetails(int id)
        {
                //physiciandb.findphysiciandb()
         //   Physician physician=physiciandb.findphysiciandb(id);
            return findphysiciandb.findphysician(id);
                
        }
    }
}