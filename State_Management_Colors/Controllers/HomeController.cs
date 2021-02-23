using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using State_Management_Colors.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace State_Management_Colors.Controllers
{
    public class HomeController : Controller
    {
        public List<Country> Countries { get; set; }
        public HomeController()
        {
            Countries = new List<Country>();
            List<string> langs = new List<string>();
            langs.Add("English");
            langs.Add("French");
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Black");
            Country c = new Country("Stankonia", langs, "Valvete amici!", colors, "Dopest country on Earth");

            List<string> langs2 = new List<string>();
            langs.Add("German");
            langs.Add("French");
            langs.Add("English");
            List<string> colors2 = new List<string>();
            colors.Add("Blue");
            colors.Add("Gold");
            Country c2 = new Country("France", langs2, "Bonjur!", colors2, "They do French stuff here");

            Countries.Add(c2);
            Countries.Add(c);

        }

        public IActionResult Index()
        {
            return View(Countries);
        }
        public IActionResult Details(string countryName)
        {
            //This action will search our list by name for the selected country
            Country selected = null;
            for(int i = 0; i<Countries.Count; i++)
            {
                Country c = Countries[i];
                if(c.Name == countryName)
                {
                    selected = c;
                }
            }
            return View(selected);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}