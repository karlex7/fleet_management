using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPPK_MVC.Models
{
    public class TroskoviGoriva
    {
        public int ID { get; set; }
        public int VozacID { get; set; }
        public DateTime DatumKupovine { get; set; }
        public string MjestoKupovine { get; set; }
        public float KolicinaGoriva { get; set; }
        public float Trosak { get; set; }
    }
}