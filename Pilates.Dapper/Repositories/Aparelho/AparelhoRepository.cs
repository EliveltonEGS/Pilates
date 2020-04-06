using Dapper;
using Microsoft.Extensions.Configuration;
using Pilates.DTO.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Pilates.Dapper.Repositories.Aparelho
{
    public class AparelhoRepository : AbstractRepositoryBase<AparelhoDTO>
    {
        public AparelhoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public override IEnumerable<AparelhoDTO> GetAll()
        {
            //IDbConnection dbConnection1 = new SqlConnection(ConnectionString);

            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<AparelhoDTO>("SELECT * FROM Aparelhos");
            }
        }
    }
}
