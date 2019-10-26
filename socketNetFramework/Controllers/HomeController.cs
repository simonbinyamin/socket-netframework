using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace socketNetFramework.Controllers
{

    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class HomeController : Controller
    {
        public List<string> Index()
        {

            return new List<string>() { "sss" };
        }

        public List<string> Index2()
        {

            return new List<string>() { "sss" };
        }

        [HttpPost]
        public Car Post(Car value)
        {
            return value;
        }

    }
}
