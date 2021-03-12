using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonemProjesi.Models
{
    public class Proje
    {
        public int ProjeID { get; set; }
        public string ProjeAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime EklenmeTarihi { get; set; }

        //FK
        public int OgrenciID { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
    }
}