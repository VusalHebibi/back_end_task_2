using Task_2.Models;
using Task_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Cars> cars = new List<Cars>
            {
                new Cars{Id=1, Brand="BMW", Model="X6", Average="140000 Km", Year=2013, Price= 10000},
                new Cars{Id=2, Brand="Nissan", Model="Maxima", Average="45000 Km", Year=2020, Price= 20000},
                new Cars{Id=3, Brand="Mercedes", Model="S-Class", Average="10000 Km", Year=2020, Price= 500000},
                new Cars{Id=4, Brand="Toyota", Model="Corolla", Average="200000 Km", Year=2008, Price= 5000},
            };
            List<Brands> brands = new List<Brands>
            {
                new Brands{Id=1 , Name="BMW"},
                new Brands{Id=2 , Name="Nissan"},
                new Brands{Id=3 , Name="Mercedes"},
                new Brands{Id=4 , Name="Toyota"},
            };
            List<Model> models = new List<Model>
            {
                new Model{Id=1 , Name="X7"},
                new Model{Id=2 , Name="X6"},
                new Model{Id=3 , Name="F30"},
                new Model{Id=4 , Name="F10"},
            };

            HomeViewModels homeVM = new HomeViewModels
            {
                Cars = cars,
                Brands = brands,
                Model = models

            };
            return View(homeVM);
        }
    }
}
