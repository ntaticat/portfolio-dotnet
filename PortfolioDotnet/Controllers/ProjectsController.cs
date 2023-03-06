using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortfolioDotnet.Models;

namespace PortfolioDotnet.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ILogger<ProjectsController> _logger;

        public ProjectsController(ILogger<ProjectsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var modelo = new List<ProjectViewModel>();
            modelo.Add(new ProjectViewModel
            {
                ProjectDescription = "Esta es una descripción",
                ProjectId = 1,
                ProjectName = "Mi Primer Proyecto"
            });
            modelo.Add(new ProjectViewModel
            {
                ProjectDescription = "Esta es una descripción",
                ProjectId = 2,
                ProjectName = "Mi Segundo Proyecto"
            });

            return View("Index", modelo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}