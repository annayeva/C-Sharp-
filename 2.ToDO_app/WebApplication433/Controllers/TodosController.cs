using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication433.Models;

namespace WebApplication433.Controllers
{
    public class TodosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private List<Todo> todos = new List<Todo>();

        // GET: Todos
        public ActionResult Index()
        {
            //return View(db.Todos.ToList());
            todos = db.Todos.ToList();
            return View(todos);
        }

        // GET: Todos/Details/5
        public ActionResult Details(int id)
        {
            Todo todo = db.Todos.Find(id);
            return View(todo);
           
        }

        // GET: Todos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todos/Create
        [HttpPost]
        public ActionResult Create(Todo todo)
        {
            if (ModelState.IsValid)
            {
                todo.Created = DateTime.Now;
                todo.Done = false;
                db.Todos.Add(todo);
                db.SaveChanges();
                return RedirectToAction("Index", todos);
            }
            return View();
        }


        public ActionResult Completed()
        {
            todos = this.db.Todos.ToList();
            return View("Completed", todos);
        }

        public ActionResult Active()
        {
            todos = this.db.Todos.ToList();
            return View("Active", todos);
        }

        [HttpGet]
        public ActionResult Done(int id)
        {
            Todo todo = db.Todos.Find(id);
            if (todo.Done)
            {
                todo.Done = false;
            
            }
            else
            {
                todo.Done = true;

            }
            db.Entry(todo).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult TodaysDate()
        {
            return Content(DateTime.Now.ToString());
        }

        // POST: Todos/Edit/5
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

        // GET: Todos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Todos/Delete/5
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
