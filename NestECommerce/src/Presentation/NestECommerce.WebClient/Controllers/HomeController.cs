using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace NestECommerce.WebClient.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
