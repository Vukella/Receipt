using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Common.Domain
{
    [Serializable]
    public class Sastojak : IEntity
    {
        public int IDSastojak { get; set; }
        public string SasNaziv { get; set; }
        public SasVrsta SasVrsta { get; set; }
        public int KalorijskaVrednost { get; set; } //za 100g

        public string TableName => "sastojak";

        public string Values => throw new NotImplementedException();

        public string PrimaryKey => "IDSastojak"; 

        public string DisplayValue => SasNaziv;

        public string GetByIDQuery()
        {
            return $"idsastojak = {IDSastojak}";
        }

        public string GetFilterQuery(string filter)
        {
            return $"lower(sasnaziv) like '%{filter.ToLower()}%'"; 
        }

        public string GetParametres() => "@SasNaziv, @SasVrsta, @KalorijskaVrednost"; 

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Sastojak sastojak = new Sastojak()
                {
                    IDSastojak = (int)reader["IdSastojak"],
                    SasNaziv = (string)reader["SasNaziv"],
                    SasVrsta = (SasVrsta)Enum.ToObject(typeof(SasVrsta), (int)reader["SasVrsta"]),
                    KalorijskaVrednost = (int)reader["KalorijskaVrednost"],
                };
                entities.Add(sastojak);
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string GetSearchAttributes() => "*"; 


        public string JoinQuery() => ""; 

        public void PrepareCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@SasNaziv", SasNaziv);
            cmd.Parameters.AddWithValue("@SasVrsta", SasVrsta);
            cmd.Parameters.AddWithValue("@KalorijskaVrednost", KalorijskaVrednost); 
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Sastojak sastojak = new Sastojak()
                {
                    IDSastojak = (int)reader["IdSastojak"],
                    SasNaziv = (string)reader["SasNaziv"],
                    SasVrsta = (SasVrsta)Enum.ToObject(typeof(SasVrsta), (int)reader["SasVrsta"]),
                    KalorijskaVrednost = (int)reader["KalorijskaVrednost"]
                };
                entities.Add(sastojak);
            }
            return entities;
        }
        public string UpdateQuery()
        {
            return $"SasNaziv='{SasNaziv}',SasVrsta='{(int)SasVrsta}',KalorijskaVrednost='{KalorijskaVrednost}'";
        }
        public override string ToString()
        {
            return SasNaziv;
        }
    }
}
