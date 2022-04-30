using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TravelClient.Models;

namespace TravelClient.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly ILogger<DestinationsController> _logger;

        public DestinationsController(ILogger<DestinationsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
        var allDestinations = Destination.GetDestinations();
        return View(allDestinations);
        }
    }
}
