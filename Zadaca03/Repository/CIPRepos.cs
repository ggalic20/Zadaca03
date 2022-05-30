using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca03.Models;

namespace Zadaca03.Repository
{
    public class CIPRepos
    {
        public static CIP GetCIP(int id)
        {
            CIP cip = null;
            DB.SetConfiguration("ggalic20_DB", "ggalic20", "-V^DAfac");
            string sql = $"SELECT * FROM CIP WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                cip = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return cip;
        }

        public static List<CIP> GetCIPs()
        {

            List<CIP> cips = new List<CIP>();

            string sql = "SELECT * FROM CIP";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                CIP cip = CreateObject(reader);
                cips.Add(cip);
            }

            reader.Close();
            DB.CloseConnection();

            return cips;
        }

        private static CIP CreateObject(SqlDataReader reader)
        {
            int Id = int.Parse(reader["id"].ToString());
            string ime = reader["ImeiPrezime"].ToString();
            var cip = new CIP
            {
                id = Id,
                ImeiPrezime = ime,

            };
            return cip;
        }

        public static void SaveObject(string Ime, string datum, string Izvor,string Opis, string Naziv, string Projekt, string Vrsta)
        {
            /*DateTime date = DateTime.Parse(datum);*/
            List<Oprema> oprema = Repository.OpremaRepos.GetOpremas();
            var zadnji = oprema.Last();
            var id = zadnji.id + 1;
            string sql = $"INSERT INTO Oprema (id, DatumZaprimanja, Zaprimio, IzvorFinanciranja, NazivProjekta, VrstaOpreme, NazivOpreme, OpisOpreme) VALUES ({id},'{datum}','{Ime}','{Izvor}','{Projekt}','{Vrsta}','{Naziv}','{Opis}') ";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }
    }
}
