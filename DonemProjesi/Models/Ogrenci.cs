using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonemProjesi.Models
{
    public class Ogrenci
    {
        public int OgrenciID { get; set; }
        public int OgrenciNumarasi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bolum { get; set; }
        public short Sinif { get; set; }
        public string Yetenekler { get; set; }
        public string Sifre { get; set; }

        //FK
        public List<Proje> Projeler { get; set; }
    }
}