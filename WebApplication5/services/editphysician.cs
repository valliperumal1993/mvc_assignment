using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5;
using WebApplication5.interfaces;
using WebApplication5.DAL;

namespace WebApplication5.services
{
    public class Editphysician : Ieditphysiciandetails
    {
        Editphysiciandetailsdb editphysiciandetailsdb;
              public Editphysician()
        {
            editphysiciandetailsdb = new Editphysiciandetailsdb();
        }
              public void Edit(Physician physician)
              {
                  editphysiciandetailsdb.Editphysiciandb(physician);
              }
    }
}