using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string DisplayValue { get; }
        string PrimaryKey {  get; }

        List<IEntity> GetReaderList(SqlDataReader reader);
        IEntity GetReaderResult(SqlDataReader reader);
        List<IEntity> ReadAllSearch(SqlDataReader reader);

        void PrepareCommand(SqlCommand command);

        string GetParametres();
        string UpdateQuery();
        string JoinQuery();
        string GetByIDQuery();
        string GetSearchAttributes();
        string GetFilterQuery(string filter);

    }
}
