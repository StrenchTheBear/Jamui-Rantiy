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
    public class AgregarController : Controller
    {
        private readonly ILogger<AgregarController> _logger;

        public AgregarController(ILogger<AgregarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

         [HttpPost]
        public IActionResult Registrar(Agregar objAgregar){
            if (ModelState.IsValid)
            {
                objAgregar.Response = "¡Producto agregado exitosamente!";
            }
            return View("index", objAgregar);
        }
    }
}