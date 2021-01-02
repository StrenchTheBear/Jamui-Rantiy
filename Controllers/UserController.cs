using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Jamui_Rantiy.Models;
using Jamui_Rantiy.Data;
using System.Dynamic;

namespace Jamui_Rantiy.Controllers
{
    public class UserController : Controller
    {

       private readonly ILogger<UserController> _logger;
       private readonly ApplicationDbContext _context;


        public UserController(ILogger<UserController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var listContactos=_context.Contactos.ToList();
            return View(listContactos);
        }

        public IActionResult Create()
        {
            var listProductos=_context.Productos.ToList();
            User contacto = new User();
            dynamic model = new ExpandoObject();
            model.contacto = contacto;
            model.productos = listProductos;
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateDynamic(dynamic data){
            User objContacto = new User();
            objContacto.Name =data.Name;
            objContacto.Email =data.Email;
            _context.Add(objContacto);
            _context.SaveChanges();
            return View(objContacto);
        }
     

        [HttpPost]
        public IActionResult Create(User objContacto){
            if (ModelState.IsValid)
            {
                _context.Add(objContacto);
                _context.SaveChanges();
                objContacto.Response = "Gracias estamos en contacto";
            }
            return View(objContacto);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contacto = await _context.Contactos.FindAsync(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,LastName,Email,Phone")] User contacto)
        {
            if (id != contacto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contacto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contacto);
        }
        

        public IActionResult Delete(int? id)
        {
            var contacto = _context.Contactos.Find(id);
            _context.Contactos.Remove(contacto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}