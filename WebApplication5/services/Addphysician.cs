using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5;
using WebApplication5.interfaces;
using WebApplication5.DAL;


namespace WebApplication5.services
{
    public class Addphysician:Iaddphysician
    {
        Addphysiciandb addphysiciandb;
        public Addphysician()
        {
            addphysiciandb = new Addphysiciandb();
        }

       public void save(Physician physician)
        {
            addphysiciandb.SavePhysiciandb(physician);
        }
    }
}