using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltraRacingTimes.Models;
using UltraRacingTimes.Services;
using UltraRacingTimes.ViewModels;

namespace UltraRacingTimes.Controllers.Web
{
    public class AppController: Controller
    {
        private RaceTimeContext _context;

        public AppController(RaceTimeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var racers = _context.Racers.OrderBy(r => r.Name).ToString();

            return View(racers);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Racers()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Racers(RacerViewModel racer)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        RacersList.Add(racer);
        //        ModelState.Clear();
        //    }
        //    return View();
        //}
    }
}
