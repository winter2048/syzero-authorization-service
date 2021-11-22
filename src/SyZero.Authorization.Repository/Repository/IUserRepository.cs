
using SyZero.Authorization.Core.Users;
using SyZero.Domain.Repository;

namespace SyZero.Authorization.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        string GetTest();
    }
}



