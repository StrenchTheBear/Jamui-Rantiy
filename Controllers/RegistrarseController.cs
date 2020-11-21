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
    public class ContactoController : Controller
    {

       private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Contacto objContacto){
            if (ModelState.IsValid)
            {
                objContacto.Response = "Gracias por registrarse";
            }
            return View("index", objContacto);
        }

    }
}