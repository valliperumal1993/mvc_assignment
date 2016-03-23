using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5;
using WebApplication5.DAL;
using WebApplication5.interfaces;



namespace WebApplication5.services
{
    public class Deletephysician:Ideletephysician
    {
        Deletephysiciandb deletephysiciandb;
        public Deletephysician()
        {
            deletephysiciandb = new Deletephysiciandb();
        }
       public void removephysician(int id)
    {
        deletephysiciandb.delete(id);
    }
    }
}