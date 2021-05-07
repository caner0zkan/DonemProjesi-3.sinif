using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public List<Ogrenci> Ogrenciler { get; set; }
    }
}