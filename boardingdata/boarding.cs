using boardingdata.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boardingdata
{
    public class boarding: DbContext
    {
        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            base.OnConfiguring(ob);

            ob.UseSqlServer("Server=localhost;Database=boardingitalic;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<HeaderSliderImage> SliderImages {get;set;}
        public DbSet<WCUBox> WCUBoxs {get;set;}
        public DbSet<Travel> Travels {get;set;}
    }
}
