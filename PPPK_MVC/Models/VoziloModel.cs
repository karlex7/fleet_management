using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPPK_MVC.Models
{
    public class VoziloModel
    {
        public int ID { get; set; }
        public int MarkaID { get; set; }
        public int GodinaProizvodnje { get; set; }
        public float PocetniKilometri { get; set; }
       
    }
}