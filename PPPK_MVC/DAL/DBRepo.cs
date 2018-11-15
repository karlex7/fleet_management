using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PPPK_MVC.Models;

namespace PPPK_MVC.DAL
{
    public class DBRepo : IRepo
    {
        private string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public void AddPutniNalog(PutniNalogModel nalog)
        {
            using (SqlConnection con=new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"INSERT_PUTNI_NALOG";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", nalog.ID);
                    cmd.Parameters.AddWithValue("@VozacID", nalog.VozacID);
                    cmd.Parameters.AddWithValue("@DatumPocetka", nalog.DatumPocetka);
                    cmd.Parameters.AddWithValue("@DatumZavrsetka", nalog.DatumZavrsetka);
                    cmd.Parameters.AddWithValue("@PrijedeniKilometri", nalog.PrjedeniKilometri);
                    cmd.Parameters.AddWithValue("@PracenjePrijedeneRudeID", nalog.PracenjeRuteID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddVozac(VozacModel vozac)
        {
            throw new NotImplementedException();
        }

        public void AddVozilo(VoziloModel vozilo)
        {
            throw new NotImplementedException();
        }

        public void DeletePutniNalog(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteVozac(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteVozilo(int id)
        {
            throw new NotImplementedException();
        }

        public void EditPutniNalog(PutniNalogModel nalog)
        {
            throw new NotImplementedException();
        }

        public void EditVozac(VozacModel vozac)
        {
            throw new NotImplementedException();
        }

        public void EditVozilo(VoziloModel vozilo)
        {
            throw new NotImplementedException();
        }

        public List<MarkaVozilaModel> GetMarkeVozila()
        {
            throw new NotImplementedException();
        }

        public PutniNalogModel GetPutniNalog(int id)
        {
            throw new NotImplementedException();
        }

        public List<PutniNalogModel> GetPutniNalogs()
        {
            throw new NotImplementedException();
        }

        public List<ServisniTroskoviModel> GetServisniTroskovi()
        {
            throw new NotImplementedException();
        }

        public List<TipVozilaModel> GetTipVozilaModels()
        {
            throw new NotImplementedException();
        }

        public List<TroskoviGoriva> GetTroskoviGorivas()
        {
            throw new NotImplementedException();
        }

        public VozacModel GetVozac(int id)
        {
            throw new NotImplementedException();
        }

        public List<VozacModel> GetVozaci()
        {
            throw new NotImplementedException();
        }

        public List<VoziloModel> GetVozila()
        {
            throw new NotImplementedException();
        }

        public VoziloModel GetVozilo(int id)
        {
            throw new NotImplementedException();
        }
    }
}