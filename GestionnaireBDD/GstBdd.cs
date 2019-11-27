using ClassesMetier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GestionnaireBDD
{
    public class GstBdd
    {
        MySqlConnection cnx;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public GstBdd()
        {
            string driver = "server=localhost;user id=root;password=;database=gestionsalles";
            cnx = new MySqlConnection(driver);
            cnx.Open();
        }

        public List<Manifestation> GetAllManifestations()
        {
            List<Manifestation> lesManifs = new List<Manifestation>();
            cmd = new MySqlCommand("SELECT * FROM manifestation", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Manifestation uneManif = new Manifestation()
                {
                    IdManif = Convert.ToInt32(dr[0].ToString()),
                    NomManif = dr[1].ToString(),
                    DateDebutManif = dr[2].ToString(),
                    DateFinManif = dr[3].ToString(), 
                    //LaSalle
                    //Latitude = Convert.ToDouble(dr[4].ToString()),
                    //Longitude = Convert.ToDouble(dr[5].ToString())
                };
                lesManifs.Add(uneManif);
            }
            dr.Close();
            return lesManifs;



            return null;
        }

        public List<Place> GetAllPlacesByIdManifestation(int idManif,int idSalle)
        {
            return null;
        }

        public List<Tarif> GetAllTarifs()
        {
            return null;
        }

        public void ReserverPlace(int idPlace, int idSalle,int idManif)
        {
            
        }
    }
}
