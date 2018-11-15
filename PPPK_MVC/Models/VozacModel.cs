using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPPK_MVC.Models
{
    public class VozacModel
    {
        public Guid ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojMobitela { get; set; }
        public string BrojVozacke { get; set; }
        public VozacModel(string ime,string prezime,string brojMobitela,string brokVozacke)
        {
            ID = Guid.NewGuid();
            Ime = ime;
            Prezime = prezime;
            BrojMobitela = brojMobitela;
            BrojVozacke = brokVozacke;
        }
        public VozacModel()
        {

        }
        public Guid GetVozacID()
        {
            return this.ID;
        }
        public string GetImeVozaca(Guid ID)
        {
            return this.Ime;
        }
        public string GetPrezimeVozaca(Guid ID)
        {
            return this.Prezime;
        }
        public string GetBrojMobitelaVozaca(Guid ID)
        {
            return this.BrojMobitela;
        }
        public string GetBrojVozackeVozaca(Guid ID)
        {
            return this.BrojVozacke;
        }
        public override string ToString()
        {
            return Ime+" " +Prezime;
        }

    }
}