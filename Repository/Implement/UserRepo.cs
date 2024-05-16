using Dapper;
using Dbmodel.Response;
using Microsoft.Extensions.Configuration;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implement
{
    public class UserRepo : IUserRepo
    {
        private readonly IConfiguration _IConfiguration;
        public UserRepo(IConfiguration IConfiguration)
        {
            _IConfiguration = IConfiguration;
        }
        public SqlConnection connection => new SqlConnection(_IConfiguration["ConnectionStrings:DefaultConnection"]);

        public async Task<IEnumerable<getUserListData>> getUserListData()
        {
            IEnumerable<getUserListData> userList = new List<getUserListData>();
            using (SqlConnection con = connection)
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("", "");
                userList = await con.QueryAsync<getUserListData>("GetUserList", null, commandType: CommandType.StoredProcedure);
                return userList;
            }
        }
    }
}
