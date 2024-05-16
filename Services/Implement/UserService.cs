using Dbmodel.Response;
using Repository.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _IUserRepo;
        public UserService(IUserRepo IUserRepo)
        {
            _IUserRepo = IUserRepo;
        }

        public async Task<IEnumerable<getUserListData>> getUserListData()
        {
            return await _IUserRepo.getUserListData();
        }
    }
}
