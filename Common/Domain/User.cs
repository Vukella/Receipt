using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class User : IEntity
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string TableName => "[user]";

        public string Values => Username;

        public string PrimaryKey => IdUser.ToString();

        public string DisplayValue => FirstName + " " + LastName;

        public string GetByIDQuery()
        {
            return $"Username='{Username}' AND Password='{Password}'";
        }

        public string GetFilterQuery(string filter)
        {
            throw new NotImplementedException();
        }

        public string GetParametres()
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                User user = new User
                {
                    IdUser = (int)reader["IdUser"],
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"]
                };
                return user;
            }
            return null;
        }

        public string GetSearchAttributes()
        {
            throw new NotImplementedException();
        }

        public string JoinQuery()
        {
            throw new NotImplementedException();
        }

        public void PrepareCommand(SqlCommand command)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string UpdateQuery()
        {
            throw new NotImplementedException();
        }
    }
}
