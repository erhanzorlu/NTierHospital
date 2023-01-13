using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Doktor> Doctors { get; set; }
        public DbSet<Hemsire> Nurses { get; set; }
        public DbSet<Randevu> Appointments{ get; set; }
        public DbSet<Poliklinik> Policlinic { get; set; }
        public DbSet<Hasta> Patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost; Database = HospitalDb; Trusted_Connection = true;TrustServerCertificate = true");
            }
        }
    }
}
