
using SyZero.Authorization.Core.Users;

namespace SyZero.Authorization.Repository
{
    public class UserRepository : AuthorizationRepositoryBase<User>, IUserRepository
    {
        public UserRepository(AuthorizationDbContext dbContextProvider) : base(dbContextProvider)
        {

        }

        public string GetTest()
        {

            return "xxxxxx";

        }


    }
}



