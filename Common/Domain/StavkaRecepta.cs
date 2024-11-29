using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Common.Domain
{
    [Serializable]
    public class StavkaRecepta : IEntity
    {
        public int IDRecepta { get; set; }
        public int RedniBrojStavke { get; set; }
        public int TrajanjeStavkeUMin { get; set; }
        public string TekstKoraka { get; set; }
        public Sastojak PotrebniSastojak { get; set; }
        public Masina Masina { get; set; }
        public string MasinaNaziv { get; set; }

        public string TableName => "stavka_recepta";

        public string DisplayValue => RedniBrojStavke.ToString() + ". " + TekstKoraka + " (" + TrajanjeStavkeUMin + "min.)";

        public string PrimaryKey => "IDRecepta,RedniBrojStavke";

        public string GetByIDQuery()
        {
            return $"idrecept={IDRecepta},rednibrojstavke={RedniBrojStavke}";
        }

        public string GetFilterQuery(string filter)
        {
            throw new NotImplementedException();
        }

        public string GetParametres() => "@IDRecepta, @RedniBrojStavke, @TrajanjeStavkeUMin, @masinaid, @sastojakid, @TekstKoraka";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                StavkaRecepta stavka = new StavkaRecepta();
                stavka.IDRecepta = reader.GetInt32(0);
                stavka.RedniBrojStavke = reader.GetInt32(1);
                stavka.TrajanjeStavkeUMin = reader.GetInt32(2);
                stavka.TekstKoraka = reader.GetString(5);
                stavka.MasinaNaziv = reader.GetString(7);
                Masina masina = new Masina()
                {
                    IDMasina = reader.GetInt32(6),
                    MasNaziv = reader.GetString(7)
                }; 
                Sastojak sastojak = new Sastojak()
                {
                    IDSastojak = reader.GetInt32(8),
                    SasNaziv = reader.GetString(9),
                    SasVrsta = (SasVrsta)Enum.ToObject(typeof(SasVrsta), reader.GetInt32(10)),
                    KalorijskaVrednost = reader.GetInt32(11),
                };
                stavka.Masina = masina; 
                stavka.PotrebniSastojak = sastojak;                
                entities.Add(stavka);
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string GetSearchAttributes() => "*";

        public string JoinQuery() => "sr join masina m on sr.masinaid=m.IdMasina join sastojak s on sr.sastojakid=s.IdSastojak";

        public void PrepareCommand(SqlCommand command)
        {
            command.Parameters.AddWithValue("@IDRecepta", IDRecepta);
            command.Parameters.AddWithValue("@RedniBrojStavke", RedniBrojStavke);

            command.Parameters.AddWithValue("@TrajanjeStavkeUMin", TrajanjeStavkeUMin);
            command.Parameters.AddWithValue("@TekstKoraka", TekstKoraka);

            command.Parameters.AddWithValue("@masinaid", Masina.IDMasina);
            command.Parameters.AddWithValue("@sastojakid", PotrebniSastojak.IDSastojak);

        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                StavkaRecepta stavka = new StavkaRecepta();
                stavka.IDRecepta = reader.GetInt32(0);
                stavka.RedniBrojStavke = reader.GetInt32(1);
                stavka.TrajanjeStavkeUMin = reader.GetInt32(2);
                stavka.TekstKoraka = reader.GetString(5);
                stavka.MasinaNaziv = reader.GetString(7);
                Masina masina = new Masina()
                {
                    IDMasina = reader.GetInt32(6),
                    MasNaziv = reader.GetString(7)
                };
                Sastojak sastojak = new Sastojak()
                {
                    IDSastojak = reader.GetInt32(8),
                    SasNaziv = reader.GetString(9),
                    SasVrsta = (SasVrsta)Enum.ToObject(typeof(SasVrsta), reader.GetInt32(10)),
                    KalorijskaVrednost = reader.GetInt32(11),
                };
                stavka.Masina = masina; 
                stavka.PotrebniSastojak = sastojak;
                entities.Add(stavka);
            }
            return entities;
        }

        public string UpdateQuery()
        {
            return $"TrajanjeStavkeUMin={TrajanjeStavkeUMin},TekstKoraka={TekstKoraka}";
        }
    }
}
