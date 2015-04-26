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
            TEAM4OIES.Models.TestimonialModels displayTestimonials = new TEAM4OIES.Models.TestimonialModels();
            ViewData["testimonials"] = displayTestimonials.DisplaySurgeonName();
            return View();
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
            testimonials.AddToTestimonial(comment, 2);

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

            ViewData["search"] =search.GetTestimonial(keyword);
         
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
