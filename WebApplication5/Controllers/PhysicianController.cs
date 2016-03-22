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
       private HospitalEntities db = new HospitalEntities();
        List<Hospital> hospital_list ;//= db.Hospitals.ToList<Hospital>();
        List<Speciality> Speciality_list ;//= db.Specialities.ToList<Speciality>();
        // GET: /Physician/
        public ActionResult Index()
        {  
       //   ViewBag.hs = hospital_list.Where(m => m.Id == 1).FirstOrDefault().HospitalName;
   
            Physiciandetails physiciandetails = new Physiciandetails();
            IEnumerable<Physician> physicianlist = physiciandetails.physician_list();
            return View(physicianlist);
        }

        // GET: /Physician/Details/5
    /*   public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        
           showphysiciandetails show = new showphysiciandetails();
           Physician physician=  show.showdetails(id);
           if (physician == null)
            {
                return HttpNotFound();
            }
           return View(physician);
        }
        */
        // GET: /Physician/Create
        public ActionResult Create()
        {
          hospital_list = db.Hospitals.ToList<Hospital>();
          Speciality_list = db.Specialities.ToList<Speciality>();
          ViewBag.hlist = hospital_list;
          ViewBag.slist = Speciality_list;
          return View();
        }

        // POST: /Physician/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Npi,Name,Age,speciality,hospital,ConsultationCharges")] Physician physician)
        
        {
            if (ModelState.IsValid)
            {
              // ViewBag.hName = hospital_list.Where(m => m.Id == hospital).FirstOrDefault().HospitalName;
               //ViewBag.sName = Speciality_list.Where(m => m.spec_id == speciality).FirstOrDefault().speciality1;
              //  db.Physicians.Add(ViewBag.hName);
               //m => m.Id == ddlcountry).FirstOrDefault().CountryName;
                Addphysician addphysician = new Addphysician();
                addphysician.save(physician);
                return RedirectToAction("Index");
            }
         
            return View();
        }

        // GET: /Physician/Edit/5
        public ActionResult Edit(string id)
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
            return View(physician);
        }

        // POST: /Physician/Edit/5
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Npi,Name,Age,Speciality,Hospital,ConsultationCharges")] Physician physician)
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
        public ActionResult DeleteConfirmed(string id)
        {
            
            Deletephysician deletephysician = new Deletephysician();
            deletephysician.removephysician(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
