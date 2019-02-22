using Ahbc.Exam.Prep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Ahbc.Exam.Prep.Controllers
{
    public class JokesController : Controller
    {
        // GET: Jokes
        public async Task<ActionResult> Index()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://api.chucknorris.io/jokes/random");
            var joke = await response.Content.ReadAsAsync<Joke>();

            return View(joke);
        }

        // GET: Jokes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jokes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jokes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Jokes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jokes/Edit/5
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

        // GET: Jokes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jokes/Delete/5
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
