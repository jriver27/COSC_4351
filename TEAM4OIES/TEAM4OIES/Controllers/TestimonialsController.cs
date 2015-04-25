using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEAM4OIES.Controllers
{
    public class TestimonialsController : Controller
    {
        //
        // GET: /Testimonials/
        public ActionResult Index()
        {

            //TEAM4OIES.Models.InstitutionModels institutions = new TEAM4OIES.Models.InstitutionModels();
            //institutions.addToInstitution(000002, "123 Hospital");
            //TEAM4OIES.Models.SurgeonModels surgeon = new TEAM4OIES.Models.SurgeonModels();
            //surgeon.addToSurgeon(1, 2, "John", "Smith", "jsmith", "1", "jsmith@uh.edu", 000002, true, true);
            //TEAM4OIES.Models.TestimonialModels testimonials = new TEAM4OIES.Models.TestimonialModels();
            //testimonials.addToTestimonial(000002, "excellent product!", 2);
            //TEAM4OIES.Models.TestimonialModels displayTestimonials = new TEAM4OIES.Models.TestimonialModels();
            //displayTestimonials.showTestimonial();
            TEAM4OIES.Models.TestimonialModels displayTestimonials = new TEAM4OIES.Models.TestimonialModels();
            ViewData["testimonials"] = displayTestimonials.displaySurgeonName();
            return View("Index");
        }

        //
        // GET: /Testimonials/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Testimonials/Create

        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost] //form action="/Testimonials"
        public ActionResult Index (FormCollection collection)
        {

            TEAM4OIES.Models.TestimonialModels testimonials = new TEAM4OIES.Models.TestimonialModels();
            String comment = Request.Form["comments"];
            testimonials.addToTestimonial(000003, comment, 3);

            return View("Index");
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Search()
        {

            return View("Search");
        }

        [HttpPost]
        public ActionResult Search(FormCollection form)
        {
            TEAM4OIES.Models.TestimonialModels search = new TEAM4OIES.Models.TestimonialModels();

            String keyword = Request.Form["searchText"];

            ViewData["search"] =search.getTestimonial(keyword);
         
            return View();

        }
        //
        // GET: /Testimonials/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Testimonials/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Testimonials/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Testimonials/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
