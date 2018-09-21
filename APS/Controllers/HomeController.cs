using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APS.Models;
using APS.Data;
using Microsoft.EntityFrameworkCore;

namespace APS.Controllers
{
	public class HomeController : Controller
	{
		private IBookRepository _repo;

		public HomeController(IBookRepository repository)
		{
   			_repo = repository;
		}
		public IActionResult Index()
		{
			return View("ListItem", _repo.Books.GroupBy(p => p.Category));
		}

		public IActionResult DisplayCategory(string SelectedCategory)
		{
			return View("DisplayCategory", _repo.Books.Where(p => p.Category == SelectedCategory));
		}

        public IActionResult DisplayBook(string SelectedBook)
        {
            return View("DisplayBook", _repo.Books.Where(p => p.Title == SelectedBook));
        }

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
