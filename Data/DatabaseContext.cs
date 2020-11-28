using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Jamui_Rantiy.Data
{
    public class DatabaseContext : DbContext{
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options) {

        }
        public DbSet<Jamui_Rantiy.Models.Login> Login {get; set; }
    }

}