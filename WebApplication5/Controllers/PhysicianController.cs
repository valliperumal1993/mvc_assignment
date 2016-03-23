using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5;
using WebApplication5.services;

namespace WebApplication5.Controllers
{
    public class PhysicianController : Controller
    {
      // private HospitalEntities db = new HospitalEntities();
        Hospitalnames hospitalnames = new Hospitalnames();
        Specialitynames specialitynames  = new Specialitynames();
    
        // GET: /Physician/
        public ActionResult Index()
        {  
         
            Physiciandetails physiciandetails = new Physiciandetails();
            IEnumerable<Physician> physicianlist = physiciandetails.physician_list();
            ViewBag.hospital_list = hospitalnames.Hospital_list();
            ViewBag.speciality_list = specialitynames.Speciality_list();
            return View(physicianlist);
        }

   
        // GET: /Physician/Create
        public ActionResult Create()
        {
            ViewBag.hospital_list = hospitalnames.Hospital_list();
            ViewBag.speciality_list = specialitynames.Speciality_list();
            return View();
        }

        // POST: /Physician/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Npi,Name,Age,speciality,hospital,ConsultationCharges")] Physician physician)
        
        {
            if (ModelState.IsValid)
            {
                Addphysician addphysician = new Addphysician();
                addphysician.save(physician);
                return RedirectToAction("Index");
            }
         
            return View();
        }

        // GET: /Physician/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            showphysiciandetails show = new showphysiciandetails();
            Physician physician = show.showdetails(id);
            if (physician == null)
            {
                return HttpNotFound();
            }
            ViewBag.hospital_list = hospitalnames.Hospital_list();
            ViewBag.speciality_list = specialitynames.Speciality_list();
            return View(physician);
        }

        // POST: /Physician/Edit/5
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="id,Npi,Name,Age,Speciality,Hospital,ConsultationCharges")] Physician physician)
        {
            if (ModelState.IsValid)
            {
              
                Editphysician editphysician = new Editphysician();
                editphysician.Edit(physician);
                return RedirectToAction("Index");
            }
         return View(physician);
        }
        
          [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Deletephysician deletephysician = new Deletephysician();
            deletephysician.removephysician(id);
            return RedirectToAction("Index");
        }

    }
}
