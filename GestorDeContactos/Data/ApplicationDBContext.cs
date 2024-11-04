using Microsoft.EntityFrameworkCore;
using GestorDeContactos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GestorDeContactos.Data
{
    public class ApplicationDBContext : DbContext
    {

        
        public DbSet<Contacto> Contactos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data source=GestorDeContactos.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
