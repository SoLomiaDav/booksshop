using Shop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllBooks _bookRep;
        

        public HomeController(IAllBooks bookRep)
        {
            _bookRep = bookRep;           
        }

        public ViewResult Index()
        {
            var homeBooks = new HomeViewModel
            {
                favBooks = _bookRep.getFavBooks
            };
            ViewBag.Title = "SomiBook";

            return View(homeBooks);
        }
    }
}
