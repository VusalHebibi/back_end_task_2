
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_2.Models;

namespace Task_2.Controllers
{
    public class CarController : Controller
    {
        private List<Cars> _cars;
        public CarController()
        {
            _cars = new List<Cars>
            {
                new Cars{Id=1, Brand="BMW", Model="X6", Average="110000 Km", Year=2013, Price= 10000},
                new Cars{Id=2, Brand="Nissan", Model="Maxima", Average="45000 Km", Year=2020, Price= 20000},
                new Cars{Id=3, Brand="Mercedes", Model="S-Class", Average="10000 Km", Year=2020, Price= 500000},
                new Cars{Id=4, Brand="Toyota", Model="Carolla", Average="200000 Km", Year=2008, Price= 5000},
            };
        }
        public IActionResult Index()
        {

            return View(_cars);
        }

        public IActionResult Detail(int id)
        {
            Cars car = _cars.Find(a => a.Id == id);
            if (car == null)
            {
                return RedirectToAction("error");
            }
            return View(car);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}

