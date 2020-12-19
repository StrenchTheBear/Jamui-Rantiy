using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Jamui_Rantiy.Data;

namespace Jamui_Rantiy.Controllers
{
    public class EditarController : Controller
    {

       private readonly ILogger<HomeController> _logger;
       private readonly ApplicationDbContext _context;


        public EditarController(ILogger<HomeController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var listProductos=_context.Productos.ToList();
            return View(listProductos);
        }


    }
}