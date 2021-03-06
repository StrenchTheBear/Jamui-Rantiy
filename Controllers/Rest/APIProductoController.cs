using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Jamui_Rantiy.Models;
using Jamui_Rantiy.Data;

namespace Jamui_Rantiy.Controllers.Rest
{
 
     [ApiController]
    [Route("api/productos")]
    public class APIProductoController : ControllerBase
    {
       private readonly ILogger<APIProductoController> _logger;
       private readonly ApplicationDbContext _context;

        public APIProductoController(ILogger<APIProductoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        
        public IEnumerable<Editar> ListProductos()
        {
             var listProductos = _context.Productos.OrderBy(s => s.ID).ToList();   
             return listProductos.ToArray();
        }

        [HttpGet("{id}")]
        public Editar GetProduct(int? id)
        {
            var producto =  _context.Productos.Find(id);
            return producto;
        }

        [HttpPost]
        public Editar CreateProduct(Editar producto){
            _context.Add(producto);
            _context.SaveChanges();
            return producto;
        }
    } 
  
}
