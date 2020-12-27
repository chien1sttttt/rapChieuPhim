using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rapChieuPhim.ApiIntegration;
using rapChieuPhim.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace rapChieuPhim.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ISlideApiClient _slideApiClient;

        public HomeController(ILogger<HomeController> logger, ISlideApiClient slideApiClient)
        {
            _logger = logger;
            _slideApiClient = slideApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                Slides = await _slideApiClient.GetAll()
            };
            return View(viewModel);
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