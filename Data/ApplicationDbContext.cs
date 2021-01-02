using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Jamui_Rantiy.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}

          public DbSet<Jamui_Rantiy.Models.Editar> Productos { get; set; }
          public DbSet<Jamui_Rantiy.Models.Contacto> Contactos { get; set; }
    }
}
