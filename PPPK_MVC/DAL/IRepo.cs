using PPPK_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_MVC.DAL
{
    public interface IRepo
    {
        //VOZAC
        List<VozacModel> GetVozaci();
        VozacModel GetVozac(int id);
        void AddVozac(VozacModel vozac);
        void EditVozac(VozacModel vozac);
        void DeleteVozac(int id);

        //VOZILO
        List<VoziloModel> GetVozila();
        VoziloModel GetVozilo(int id);
        void AddVozilo(VoziloModel vozilo);
        void EditVozilo(VoziloModel vozilo);
        void DeleteVozilo(int id);

        //PUTNI NALOG
        List<PutniNalogModel> GetPutniNalogs();
        PutniNalogModel GetPutniNalog(int id);
        void AddPutniNalog(PutniNalogModel nalog);
        void EditPutniNalog(PutniNalogModel nalog);
        void DeletePutniNalog(int id);

        //DDL
        List<MarkaVozilaModel> GetMarkeVozila();
        List<TipVozilaModel> GetTipVozilaModels();
        List<TroskoviGoriva> GetTroskoviGorivas();
        List<ServisniTroskoviModel> GetServisniTroskovi();

    }
}
