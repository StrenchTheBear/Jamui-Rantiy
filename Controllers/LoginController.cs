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
 public class LoginController : Controller
    {
     private readonly ILogger<LoginController> _logger;

     private readonly DatabaseContext _context;

        public LoginController(ILogger<LoginController> logger, 
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult Registrar(Contacto objcontacto) {

            if(ModelState.IsValid){

                // grabar base de datos
                _context.Add(objcontacto);
                _context.SaveChanges();

                objcontacto.Response = "Gracias estamos en contacto";
            }
            return View("index", objcontacto);
        }
    }
}
        
    }