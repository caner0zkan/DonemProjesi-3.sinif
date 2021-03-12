using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonemProjesi.Models
{
    public class Basvuru
    {
        public int BasvuruID { get; set; }
        public bool ProjeSahibimi { get; set; }
        public bool KabulEdildimi { get; set; }

        //FK
        public int ProjeID { get; set; }
        public int OgrenciID { get; set; }
    }
}