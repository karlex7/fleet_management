using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPPK_MVC.Models
{
    public class VoziloModel
    {
        public Guid ID { get; set; }
        public int TipID { get; set; }
        public int MarkaID { get; set; }
        public int GodinaProizvodnje { get; set; }
        public float PocetniKilometri { get; set; }
        public VoziloModel(int tipID, int markaID, int godinaProizvodnje,float pocetniKilometri)
        {
            ID = Guid.NewGuid();
            TipID = tipID;
            MarkaID = markaID;
            GodinaProizvodnje = godinaProizvodnje;
            PocetniKilometri = pocetniKilometri;
        }
        public VoziloModel()
        {

        }

    }
}