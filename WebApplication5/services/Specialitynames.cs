using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5;
using WebApplication5.interfaces;
using WebApplication5.DAL;

namespace WebApplication5.services
{
    public class Specialitynames : Ispeciality
    {
        Specialitydb specialitydb ;
        public Specialitynames()
        {
            specialitydb = new Specialitydb();
        }
        public IEnumerable<Speciality> Speciality_list()
        {

            return (specialitydb.Specialitynamelist());
        }
    }
}