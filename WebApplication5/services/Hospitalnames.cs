using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5;
using WebApplication5.DAL;
using WebApplication5.interfaces;

namespace WebApplication5.services
{
    public class Hospitalnames:Ihospitalnames
    {
        Hospitalnamesdb hospitalnamesdb;
        public Hospitalnames()
        {
         hospitalnamesdb= new  Hospitalnamesdb() ;
        }

       public IEnumerable<Hospital> Hospital_list()
        {
            return hospitalnamesdb.hospitalnamelist();
        }
    }
}