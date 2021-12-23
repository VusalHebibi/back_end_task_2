using Task_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_2.ViewModels
{
    public class HomeViewModels
    {
        public List<Cars> Cars { get; set; }
        public List<Brands> Brands { get; set; }
        public List<Model> Model { get; set; }
    }
}
