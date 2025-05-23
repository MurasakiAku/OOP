﻿using Mendoukusai.Data;
using Mendoukusai.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Mendoukusai.Controllers
{
    
	public class ApplicationTypeController : Controller
	{
		private readonly ApplicationDbContext _db;
		public ApplicationTypeController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			IEnumerable<ApplicationType> objList = _db.ApplicationType;
			return View(objList);
		}

		//Get-create
		public IActionResult Create()
		{
			return View();
		}

		//Post-create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(ApplicationType obj)
		{
			if (ModelState.IsValid)
			{
				_db.ApplicationType.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);

		}
		//Get-edit
		public IActionResult Edit(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			var obj = _db.ApplicationType.Find(id);
			if (obj == null)
			{
				return NotFound();
			}
			return View(obj);
		}



		//Post-edit
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(ApplicationType obj)
		{
			if (ModelState.IsValid)
			{
				_db.ApplicationType.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);

		}
		//Get-delete
		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			var obj = _db.ApplicationType.Find(id);
			if (obj == null)
			{
				return NotFound();
			}
			return View(obj);
		}



		//Post-delete
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeletePost(int? id)
		{
			var obj = _db.ApplicationType.Find(id);
			if (obj == null)
			{
				return NotFound();
			}

			_db.ApplicationType.Remove(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");



		}



	}
}
