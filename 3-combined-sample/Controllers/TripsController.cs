using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using CombinedSample.Models;

namespace CombinedSample.Controllers
{
	public class TripsController : Controller
	{
		private ApplicationDbContext _context;

		public TripsController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: Trips
		public IActionResult Index()
		{
			return View(_context.Trip.ToList());
		}

		// GET: Trips/Details/5
		public IActionResult Details(int? id)
		{
			if (id == null)
			{
				return HttpNotFound();
			}

			Trip trip = _context.Trip.Single(m => m.Id == id);
			if (trip == null)
			{
				return HttpNotFound();
			}

			return View(trip);
		}

		// GET: Trips/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Trips/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Trip trip)
		{
			if (ModelState.IsValid)
			{
				_context.Trip.Add(trip);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(trip);
		}

		// GET: Trips/Edit/5
		public IActionResult Edit(int? id)
		{
			if (id == null)
			{
				return HttpNotFound();
			}

			Trip trip = _context.Trip.Single(m => m.Id == id);
			if (trip == null)
			{
				return HttpNotFound();
			}
			return View(trip);
		}

		// POST: Trips/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Trip trip)
		{
			if (ModelState.IsValid)
			{
				_context.Update(trip);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(trip);
		}

		// GET: Trips/Delete/5
		[ActionName("Delete")]
		public IActionResult Delete(int? id)
		{
			if (id == null)
			{
				return HttpNotFound();
			}

			Trip trip = _context.Trip.Single(m => m.Id == id);
			if (trip == null)
			{
				return HttpNotFound();
			}

			return View(trip);
		}

		// POST: Trips/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(int id)
		{
			Trip trip = _context.Trip.Single(m => m.Id == id);
			_context.Trip.Remove(trip);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
