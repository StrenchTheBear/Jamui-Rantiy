using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Jamui_Rantiy.Models;
using Jamui_Rantiy.Data;
using Microsoft.EntityFrameworkCore;

namespace Jamui_Rantiy.Controllers
{
    public class AgregarController : Controller
    {
        private readonly ILogger<AgregarController> _logger;
         private readonly ApplicationDbContext _context;
      
       public AgregarController(ILogger<AgregarController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            
            _context = context;
     
        }
        public IActionResult Index()
        {
        var listProductos=_context.agregar.ToList();
            return View(listProductos);
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
