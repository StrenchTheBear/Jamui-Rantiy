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
    public class EditarController : Controller
    {
        private readonly ILogger<EditarController> _logger;
         private readonly ApplicationDbContext _context;
        public EditarController(ILogger<EditarController> logger, ApplicationDbContext context)
        {
            _logger = logger;
          _context = context;
        }

        public IActionResult Index()
        {
           var listContactos=_context.agregar.ToList();
            return View(listContactos);
        }

           public IActionResult Create()
        {
            return View();
        }

         [HttpPost]
        public IActionResult Registrar(Agregar objAgregar){
            
            if (ModelState.IsValid)
            {
                _context.Add(objAgregar);
                _context.SaveChanges();
                objAgregar.Response = "¡Producto agregado exitosamente!";
            }
            return View(objAgregar);
        }

         // GET: Contacto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contacto = await _context.agregar.FindAsync(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Message,Number")] Agregar agrecontacto)
        {
            if (id != agrecontacto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agrecontacto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(agrecontacto);
        }
        

        // GET: http://localhost:5000/Contacto/Delete/6 MUESTRA Contacto
        public IActionResult Delete(int? id)
        {
            var contacto = _context.agregar.Find(id);
            _context.agregar.Remove(contacto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}