using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Jamui_Rantiy.Models;

namespace Jamui_Rantiy.Controllers
{
    public class RegistrarseController : Controller
    {

       private readonly ILogger<RegistrarseController> _logger;

        public RegistrarseController(ILogger<RegistrarseController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Registrarse objRegistrarse){
            if (ModelState.IsValid)
            {
                objRegistrarse.Response = "Gracias por registrarse";
            }
            return View("index", objRegistrarse);
        }

    }
}