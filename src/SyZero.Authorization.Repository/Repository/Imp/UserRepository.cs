
using SyZero.Authorization.Core.Users;
using SyZero.SqlSugar.Repositories;

namespace SyZero.Authorization.Repository
{
    public class UserRepository : SqlSugarRepository<User>, IUserRepository
    {
      
        public string GetTest()
        {

            return "xxxxxx";

        }


    }
}



