using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentAPI.Models.Interfaces;

namespace StudentEnrollmentAPI.Controllers
{
    [AllowAnonymous]
    public class RosterController : Controller
    {
        private IStudent _students;

        public RosterController(IStudent student)
        {
            _students = student;
        }
        // GET: RosterController
        public async Task<ActionResult> Index()
        {
           var allStudents = await _students.GetStudents();
            return View(allStudents);
        }

        // GET: RosterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RosterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RosterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RosterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RosterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RosterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RosterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
