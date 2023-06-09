﻿using ASP_111.Models;
using ASP_111.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_111.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IDateService _dateService;
        private readonly TimeService _timeService;
        private readonly DateTimeService _dateTimeService;
        private readonly Validation _validatorService = new();
        public HomeController(ILogger<HomeController> logger, IDateService dateService, TimeService timeService, DateTimeService dateTimeService, Validation validation)
        {
            _logger = logger;
            _dateService = dateService;
            _timeService = timeService;
            _dateTimeService = dateTimeService;
            _validatorService = validation;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Intro()
        {
            return View();
        }
        public IActionResult Razor()
        {
            return View();
        }

        public IActionResult Services()
        {
            ViewData["date"] = _dateService.GetDate();
            ViewData["time"] = _timeService.GetTime();
            ViewData["datetime"] = _dateTimeService.GetNow();

            ViewData["date-hash"] = _dateService.GetHashCode();
            ViewData["time-hash"] = _timeService.GetHashCode();
            ViewData["datetime-hash"] = _dateTimeService.GetHashCode();
            ViewData["validation"] = new bool[] {
            _validatorService.ValidateLogin("NormalLogin1"),
            _validatorService.ValidateLogin("Normal_Login_2"),
            _validatorService.ValidateLogin("In-valid login"),
            _validatorService.ValidateLogin("$ invalid ++")
            };
            ViewData["ctrl-hash"] = this.GetHashCode();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public ViewResult Data()
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