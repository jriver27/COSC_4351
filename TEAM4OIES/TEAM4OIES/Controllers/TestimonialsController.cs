using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using TEAM4OIES.Models;

namespace TEAM4OIES.Controllers
{
    public class TestimonialsController : Controller
    {
        // GET: /Testimonials/
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost] //form action="/Testimonials"
        public ActionResult Index(FormCollection collection)
        {
            return View("Index");
        }
        //
        // GET: /Testimonials/Create

        public ActionResult Create()
        {
            return View("Create");
        }

        //Name of Code Artifact:Create
        //Programmer's Name:Linh Tong
        //Date it was coded: 04/25/2014
        //Date Approved:
        //SQA Approver:
        [HttpPost]//form action="/Testimonials/Create"
        public ActionResult Create(FormCollection form)
        {
            TEAM4OIES.Models.TestimonialModels testimonials = new TEAM4OIES.Models.TestimonialModels();
            String comment = Request.Form["comments"];
            testimonials.addToTestimonial(comment, 3);
            List<Testimonials> createTestList = new List<Testimonials>();
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=sqlserver.cs.uh.edu,1044;Initial Catalog=TEAM4OIES;User ID=TEAM4OIES;Password=TEAM4OIES#");
            SqlDataAdapter da = new SqlDataAdapter("SELECT Surgeon.firstName,Surgeon.lastName, Testimonial.content, Testimonial.tDate FROM Testimonial, Surgeon WHERE Testimonial.surgeonID=Surgeon.surgeonID;", con);
            da.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                createTestList.Add(new Testimonials() { firstName = dr[0].ToString(), lastName = dr[1].ToString(), content = dr[2].ToString(), tDate = dr[3].ToString() });
            }

            return View(createTestList);
        }

        public ActionResult Search()
        {
            return View("Search");
        }

        //Name of Code Artifact:Search
        //Programmer's Name:Linh Tong
        //Date it was coded: 04/25/2014
        //Date Approved:
        //SQA Approver:
        [HttpPost]
        public ActionResult Search(FormCollection form)
        {
            String keyword = Request.Form["searchText"];
            List<Testimonials> testimonialsList = new List<Testimonials>();
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=sqlserver.cs.uh.edu,1044;Initial Catalog=TEAM4OIES;User ID=TEAM4OIES;Password=TEAM4OIES#");
            SqlDataAdapter da = new SqlDataAdapter("SELECT Surgeon.firstName,Surgeon.lastName, Testimonial.content, Testimonial.tDate FROM Testimonial, Surgeon WHERE Testimonial.content LIKE '%" + keyword + "%' AND Testimonial.surgeonID=Surgeon.surgeonID;", con);
            da.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                testimonialsList.Add(new Testimonials() { firstName = dr[0].ToString(), lastName = dr[1].ToString(), content = dr[2].ToString(), tDate = dr[3].ToString() });
            }

            return View(testimonialsList);
        }

        //
        // GET: /Testimonials/Details/5

        public ActionResult Details(int id)
        {
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
