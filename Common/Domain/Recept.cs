using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Recept : IEntity
    {
        public int IDRecept { get; set; }
        public string RecNaziv { get; set; }
        public TipObroka TipObroka { get; set; }
        public int PotrebnoVremePripreme { get; set; } // u minutima
        public int UkupanBrojKalorija { get; set; }
        public List<StavkaRecepta> StavkeRecepta { get; set; }

        public string TableName => "recept"; 

        public string Values => throw new NotImplementedException();

        public string PrimaryKey => "IDrecept";

        public string DisplayValue => RecNaziv; 

        public string GetByIDQuery()
        {
            return $"idrecept = {IDRecept}";
        }

        public string GetFilterQuery(string filter)
        {
            return $"lower(recnaziv) like '%{filter.ToLower()}%'";
        }

        public string GetParametres() => "@RecNaziv, @TipObroka, @PotrebnoVremePripreme, @UkupanBrojKalorija";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Recept recept = new Recept()
                {
                    IDRecept = reader.GetInt32(0),
                    RecNaziv = reader.GetString(1),
                    TipObroka = (TipObroka)Enum.ToObject(typeof(TipObroka), reader.GetInt32(2)),
                    PotrebnoVremePripreme = reader.GetInt32(3),
                    UkupanBrojKalorija = reader.GetInt32(4),
                };
                StavkaRecepta stavka = new StavkaRecepta()
                {
                    IDRecepta = reader.GetInt32(0),
                    RedniBrojStavke = reader.GetInt32(6),
                    TrajanjeStavkeUMin = reader.GetInt32(7),
                    MasinaNaziv = reader.GetString(12),
                    Masina = new Masina()
                    {
                        IDMasina = reader.GetInt32(11), 
                        MasNaziv = reader.GetString(12)
                    },
                    PotrebniSastojak = new Sastojak()
                    {
                        IDSastojak = reader.GetInt32(13),
                        SasNaziv = reader.GetString(14),
                        SasVrsta = (SasVrsta)Enum.ToObject(typeof(SasVrsta), reader.GetInt32(15)),
                        KalorijskaVrednost = reader.GetInt32(16),
                    },
                };
                entities.Add(recept);
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string GetSearchAttributes() => "*";

        public string JoinQuery() => "r join stavka_recepta sr on r.IdRecept=sr.Receptid join masina m on sr.masinaid=m.idmasina join sastojak s on sr.sastojakid=s.idsastojak";

        public void PrepareCommand(SqlCommand command)
        {
            command.Parameters.AddWithValue("@RecNaziv", RecNaziv);
            command.Parameters.AddWithValue("@TipObroka", TipObroka);
            command.Parameters.AddWithValue("@PotrebnoVremePripreme", PotrebnoVremePripreme);
            command.Parameters.AddWithValue("@UkupanBrojKalorija", UkupanBrojKalorija);
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Recept recept = new Recept()
                {
                    IDRecept = reader.GetInt32(0),
                    RecNaziv = reader.GetString(1),
                    TipObroka = (TipObroka)Enum.ToObject(typeof(TipObroka), reader.GetInt32(2)),
                    PotrebnoVremePripreme = reader.GetInt32(3),
                    UkupanBrojKalorija = reader.GetInt32(4),
                };
                entities.Add(recept);
            }
            return entities;
        }

        public List<IEntity> ReaderAllSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string UpdateQuery()
        {
            return $"RecNaziv='{RecNaziv}',TipObroka='{(int)TipObroka}',PotrebnoVremePripreme={PotrebnoVremePripreme},UkupanBrojKalorija={UkupanBrojKalorija}";
        }
        public override string ToString()
        {
            return RecNaziv;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return IDRecept == ((Recept)obj).IDRecept;
        }

        public override int GetHashCode()
        {
            return IDRecept.GetHashCode();
        }
    }
}
