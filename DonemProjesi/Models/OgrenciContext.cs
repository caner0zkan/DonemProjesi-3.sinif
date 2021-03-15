using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DonemProjesi.Models
{
    public class OgrenciContext:DbContext
    {
        public OgrenciContext():base("projeDb")
        {
            Database.SetInitializer(new OgrenciInitializer());
        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Proje> Projeler { get; set; }
        public DbSet<Basvuru> Basvurular { get; set; }
    }
}