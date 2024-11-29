using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Common.Domain
{
    [Serializable]
    public class Masina : IEntity
    {
        public int IDMasina { get; set;}
        public string MasNaziv { get; set; }

        public string TableName => "masina";

        public string Values => throw new NotImplementedException();

        public string PrimaryKey => "IDMasina";

        public string DisplayValue => MasNaziv;

        public string GetByIDQuery()
        {
            return $"idmasina = {IDMasina}";
        }

        public string GetFilterQuery(string filter)
        {
            return $"lower(masnaziv) like '%{filter.ToLower()}%'";
        }

        public string GetParametres() => "@MasNaziv";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while(reader.Read())
            {
                Masina masina = new Masina()
                {
                    IDMasina = reader.GetInt32(0),
                    MasNaziv = reader.GetString(1),
                };
                entities.Add(masina);
            }
            return entities ;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string GetSearchAttributes() => "*";

        public string JoinQuery() => "";

        public void PrepareCommand(SqlCommand command)
        {
            command.Parameters.AddWithValue("@MasNaziv", MasNaziv);
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read()) 
            {
                Masina masina = new Masina()
                {
                    IDMasina = reader.GetInt32(0),
                    MasNaziv = reader.GetString(1)
                };
                entities.Add(masina);
            }
            return entities;
        }
        public string UpdateQuery()
        {
            return $"MasNazi='{MasNaziv}'";
        }
        public override string ToString()
        {
            return MasNaziv;
        }
    }
}
