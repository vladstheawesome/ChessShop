﻿using ChessShop.Data;
using ChessShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChessShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
			ViewData["PageTitle"] = "Category";
            ViewData["TableTitle"] = "Categories";
			IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }

        // GET
        public IActionResult Create()
        {
            ViewData["PageTitle"] = "Category / Create";
			ViewData["TableTitle"] = "Add Category";
			return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            obj.createdtime = DateTime.UtcNow;
            obj.modifiedtime = DateTime.UtcNow;

            //TODO: Temporary testing entries
            // to be fixed after login/session implementation
            obj.categoryid = Guid.NewGuid();
            obj.lastuser = Guid.Empty;
            obj.inuse = 1;
            obj.code = 4000;

            if (ModelState.IsValid)
            {
                _db.Category.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET - EDIT
        public IActionResult Edit(Guid id)
        {
            if (id == null) { return NotFound(); }

            var obj = _db.Category.Find(id);

            if (obj == null) { return NotFound(); }

            return View(obj);
        }

        // POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET - DELETE
        public IActionResult Delete(Guid id)
        {
            if (id == null) { return NotFound(); }

            var obj = _db.Category.Find(id);

            if (obj == null) { return NotFound(); }

            return View(obj);
        }

        // POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(Guid CategoryId)
        {
            var obj = _db.Category.Find(CategoryId);
            if (obj == null) { return NotFound(); }

            _db.Category.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
