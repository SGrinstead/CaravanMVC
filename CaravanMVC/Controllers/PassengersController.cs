using CaravanMVC.DataAccess;
using CaravanMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaravanMVC.Controllers
{
	public class PassengersController : Controller
	{
		private readonly CaravanMvcContext _context;

		public PassengersController(CaravanMvcContext context)
		{
			_context = context;
		}

		[Route("/wagons/{wagonId:int}/passengers/new")]
		public IActionResult New(int wagonId)
		{
			var wagon = _context.Wagons
				.Where(w => w.Id == wagonId)
				.Include(w => w.Passengers)
				.FirstOrDefault();

			return View(wagon);
		}

		[HttpPost]
		[Route("/wagons/{wagonId:int}/passengers")]
		public IActionResult Create(int wagonId, Passenger passenger)
		{
			var wagon = _context.Wagons
				.Where(w => w.Id == wagonId)
				.Include(w => w.Passengers)
				.FirstOrDefault();
			wagon.Passengers.Add(passenger);
			_context.SaveChanges();

			return Redirect($"/wagons/{wagonId}");
		}
	}
}
