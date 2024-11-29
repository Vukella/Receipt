using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Common.Domain
{
    [Serializable]
    public class Evidencija : IEntity
    {
        public int IDEvidencija { get; set; }
        public string Datum { get; set; }
        public KategorijaJela KategorijaJela { get; set; }
        public string Komentar { get; set; }
        public Recept ReceptEvidencije { get; set; }

        public string TableName => "Evidencija";

        public string Values => Datum + " " + ReceptEvidencije.RecNaziv + " " + ReceptEvidencije.TipObroka + " " + KategorijaJela;

        public string PrimaryKey => "IDEvidencija";

        public string DisplayValue => Datum + "\t" + KategorijaJela.ToString() + "\t(" + Komentar + ")"; 

        public string GetByIDQuery()
        {
            return $"IDEvidencija = {IDEvidencija}";
        }

        public string GetFilterQuery(string filter)
        {
            return $"ev.Datum LIKE '{filter}'";
        }

        public string GetParametres()
        {
            return "@Datum,@KategorijaJela,@Komentar,@ReceptId";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while(reader.Read())
            {
                Evidencija evidencija = new Evidencija()
                {
                    ReceptEvidencije = new Recept
                    {
                        IDRecept = (int)reader["IDRecept"],
                        RecNaziv = (string)reader["RecNaziv"],
                        TipObroka = (TipObroka)Enum.ToObject(typeof(TipObroka), (int)reader["TipObroka"]),
                        PotrebnoVremePripreme = (int)reader["PotrebnoVremePripreme"],
                        UkupanBrojKalorija = (int)reader["UkupanBrojKalorija"],
                    },
                    IDEvidencija = (int)reader["IdEvidencija"],
                    Datum = (string)reader["Datum"],
                    Komentar = (string)reader["Komentar"],
                    KategorijaJela = (KategorijaJela)Enum.ToObject(typeof(KategorijaJela), (int)reader["KategorijaJela"])
                };  
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string GetSearchAttributes() => "*";

        public string JoinQuery() => "e join recept r on e.Receptid=r.IdRecept";

        public void PrepareCommand(SqlCommand command)
        {
            command.Parameters.AddWithValue("@Datum",Datum);
            command.Parameters.AddWithValue("@KategorijaJela",KategorijaJela);
            command.Parameters.AddWithValue("@Komentar",Komentar);
            command.Parameters.AddWithValue("@ReceptId",ReceptEvidencije.IDRecept);
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Evidencija evidencija = new Evidencija()
                {
                    ReceptEvidencije = new Recept
                    {
                        IDRecept = (int)reader["IDRecept"],
                        RecNaziv = (string)reader["RecNaziv"],
                        TipObroka = (TipObroka)Enum.ToObject(typeof(TipObroka), (int)reader["TipObroka"]),
                        PotrebnoVremePripreme = (int)reader["PotrebnoVremePripreme"],
                        UkupanBrojKalorija = (int)reader["UkupanBrojKalorija"],
                    },
                    IDEvidencija = (int)reader["IdEvidencija"],
                    Datum = (string)reader["Datum"],
                    Komentar = (string)reader["Komentar"],
                    KategorijaJela = (KategorijaJela)Enum.ToObject(typeof(KategorijaJela), (int)reader["KategorijaJela"])
                };
                entities.Add(evidencija);
            }
            return entities;
        }

        public string UpdateQuery()
        {
            return $"Datum='{Datum}',KategorijaJela='{(int)KategorijaJela}',Komentar={Komentar},";
        }
    }

    public enum KategorijaJela 
    {
        Dorucak,
        Rucak,
        Vecera,
        Uzina
    }
}
