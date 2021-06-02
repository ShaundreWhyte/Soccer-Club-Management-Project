using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShaundreWhyte_300873223.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Clubs()
        {
            return View();
        }
        public ViewResult AddClub()
        {
            return View();
        }
        public ViewResult ClubDetails()
        {
            return View();
        }
        public ViewResult ManagePlayers()
        {
            return View();
        }

    }
}