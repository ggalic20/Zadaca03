using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca03.Models;
using DBLayer;
using System.Data.SqlClient;

namespace Zadaca03.Repository
{
    public class OpremaRepos
    {
        public static Oprema GetOprema(int id)
        {
            Oprema oprema = null;
            string sql = $"SELECT * FROM Oprema WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                oprema = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return oprema;
        }

        private static Oprema CreateObject(SqlDataReader reader)
        {
            int Id = int.Parse(reader["id"].ToString());
            DateTime datum = DateTime.Parse(reader["DatumZaprimanja"].ToString());
            string zaprimio = reader["Zaprimio"].ToString();
            string izvor = reader["IzvorFinanciranja"].ToString();
            string projekt = reader["NazivProjekta"].ToString();
            string vrsta = reader["VrstaOpreme"].ToString();
            string naziv = reader["NazivOpreme"].ToString();
            string opis = reader["OpisOpreme"].ToString();

            var oprema = new Oprema
            {
                id = Id,
                DatumZaprimanja = datum,
                Zaprimio = zaprimio,
                IzvorFinanciranja = izvor,
                NazivProjekta = projekt,
                VrstaOpreme = vrsta,
                NazivOpreme = naziv,
                OpisOpreme = opis,

            };
            return oprema;
        }
    }
}
