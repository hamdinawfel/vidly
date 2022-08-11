using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /Movies/Random

        public IActionResult Random()
        {
            var movie = new Movie() { Name = "The                                                       " };
            return View();
        }

        
    }
}