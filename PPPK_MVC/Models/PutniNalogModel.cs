using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPPK_MVC.Models
{
    public class PutniNalogModel
    {
        public int ID { get; set; }
        public int VozacID { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public float PrjedeniKilometri { get; set; }
        public int PracenjeRuteID { get; set; }
    }
}