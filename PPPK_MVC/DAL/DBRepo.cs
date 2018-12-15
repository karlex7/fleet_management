using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            using (SqlConnection con=new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd=con.CreateCommand())
                {
                    cmd.CommandText = $"INSERT_VOZAC";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", vozac.ID);
                    cmd.Parameters.AddWithValue("@Ime", vozac.Ime);
                    cmd.Parameters.AddWithValue("@Prezime", vozac.Prezime);
                    cmd.Parameters.AddWithValue("@BrojMobitela", vozac.BrojMobitela);
                    cmd.Parameters.AddWithValue("@BrojVozacke", vozac.BrojVozacke);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddVozilo(VoziloModel vozilo)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd=con.CreateCommand())
                {
                    cmd.CommandText = $"INSERT_VOZILO";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", vozilo.ID);
                    cmd.Parameters.AddWithValue("@MarkaID", vozilo.MarkaID);
                    cmd.Parameters.AddWithValue("@GodinaProizvodnje", vozilo.GodinaProizvodnje);
                    cmd.Parameters.AddWithValue("@PocetniKilometri", vozilo.PocetniKilometri);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletePutniNalog(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"DELETE FROM PutniNalog WHERE ID = '{id}'";
                    cmd.CommandType = CommandType.Text;
                    transaction.Commit();

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void DeleteVozac(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"DELETE_VOZAC";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID",id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteVozilo(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"DELETE_VOZILO";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditPutniNalog(PutniNalogModel nalog)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"UPDATE_PUTNI_NALOG";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", nalog.ID);
                    cmd.Parameters.AddWithValue("@VozacID",nalog.VozacID);
                    cmd.Parameters.AddWithValue("@DatumPocetka",nalog.DatumPocetka);
                    cmd.Parameters.AddWithValue("@DatumZavrsetka",nalog.DatumZavrsetka);
                    cmd.Parameters.AddWithValue("@PrijedeniKilometri",nalog.PrjedeniKilometri);
                    cmd.Parameters.AddWithValue("@PracenjePrijedeneRuteID",nalog.PracenjeRuteID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditVozac(VozacModel vozac)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"UPDATE_VOZAC";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID",vozac.ID);
                    cmd.Parameters.AddWithValue("@Ime",vozac.Ime);
                    cmd.Parameters.AddWithValue("@Prezime",vozac.Prezime);
                    cmd.Parameters.AddWithValue("@BrojMobitela",vozac.BrojMobitela);
                    cmd.Parameters.AddWithValue("@BrojVozacke",vozac.BrojVozacke);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditVozilo(VoziloModel vozilo)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"UPDATE_VOZILO";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", vozilo.ID);
                    cmd.Parameters.AddWithValue("@MarkaID", vozilo.MarkaID);
                    cmd.Parameters.AddWithValue("@GodinaProizvodnje", vozilo.GodinaProizvodnje);
                    cmd.Parameters.AddWithValue("@PocetniKilometri", vozilo.PocetniKilometri);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<MarkaVozilaModel> GetMarkeVozila()
        {
            List<MarkaVozilaModel> markeVozila = new List<MarkaVozilaModel>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "GET_MARKE_VOZILA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                markeVozila.Add(new MarkaVozilaModel
                                {
                                    ID = (int)r["ID"],
                                    Marka = r["Name"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            return markeVozila;
        }

        public PutniNalogModel GetPutniNalog(int id)
        {
            return GetPutniNalogs().Single(p => p.ID == id);
        }

        public List<PutniNalogModel> GetPutniNalogs()
        {
            List<PutniNalogModel> putniNalogs = new List<PutniNalogModel>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "GET_PUTNI_NALOGS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                putniNalogs.Add(new PutniNalogModel
                                {
                                    ID = (int)r["ID"],
                                    VozacID=(int)r["VozacID"],
                                    DatumPocetka=(DateTime)r["DatumPocetka"],
                                    DatumZavrsetka=(DateTime)r["DatumZavrsetka"],
                                    PrjedeniKilometri=(float)r["PrijedeniKilometri"],
                                    PracenjeRuteID=(int)r["PracenjePrijedeneRuteID"]
                                });
                            }
                        }
                    }
                }
            }
            return putniNalogs;
        }

        public List<ServisniTroskoviModel> GetServisniTroskovi()
        {
            List<ServisniTroskoviModel> servisniTroskovi = new List<ServisniTroskoviModel>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "GET_SERVISNI_TROSKOVI";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                servisniTroskovi.Add(new ServisniTroskoviModel
                                {
                                    ID = (int)r["ID"],
                                    VoziloID=(int)r["VoziloID"],
                                    Trosak=(float)r["Trosak"]
                                });
                            }
                        }
                    }
                }
            }
            return servisniTroskovi;
        }

        public List<TipVozilaModel> GetTipVozilaModels()
        {
            List<TipVozilaModel> tipoviVozila = new List<TipVozilaModel>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "GET_TIPOVI_VOZILA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                tipoviVozila.Add(new TipVozilaModel
                                {
                                    ID = (int)r["ID"],
                                    Tip = r["Tip"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            return tipoviVozila;
        }

        public List<TroskoviGoriva> GetTroskoviGorivas()
        {
            List<TroskoviGoriva> troskoviGoriva = new List<TroskoviGoriva>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "GET_TROSKOVI_GORIVA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                troskoviGoriva.Add(new TroskoviGoriva
                                {
                                    ID = (int)r["ID"],
                                    VozacID=(int)r["VozacID"],
                                    DatumKupovine=(DateTime)r["DatumTroska"],
                                    MjestoKupovine=r["MjestoKupovine"].ToString(),
                                    KolicinaGoriva=(float)r["KolicinaGoriva"],
                                    Trosak=(float)r["Cijena"]
                                });
                            }
                        }
                    }
                }
            }
            return troskoviGoriva;
        }

        public VozacModel GetVozac(int id)
        {
            return GetVozaci().Single(v => v.ID == id);
        }

        public List<VozacModel> GetVozaci()
        {
            List<VozacModel> vozaci = new List<VozacModel>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "GET_VOZACI";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                vozaci.Add(new VozacModel
                                {
                                    ID = (int)r["ID"],
                                    Ime=r["Ime"].ToString(),
                                    Prezime=r["Prezime"].ToString(),
                                    BrojMobitela=r["BrojMobitela"].ToString(),
                                    BrojVozacke =r["BrojVozacke"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            return vozaci;
        }

        public List<VoziloModel> GetVozila()
        {
            List<VoziloModel> vozila = new List<VoziloModel>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "GET_VOZILA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                vozila.Add(new VoziloModel
                                {
                                    ID = (int)r["ID"],
                                    MarkaID=(int)r["MarkaID"],
                                    GodinaProizvodnje=(int)r["GodinaPorizvodnje"],
                                    PocetniKilometri=(float)r["PocetniKilometri"]
                                });
                            }
                        }
                    }
                }
            }
            return vozila;
        }

        public VoziloModel GetVozilo(int id)
        {
            return GetVozila().Single(v => v.ID == id);
        }
    }
}