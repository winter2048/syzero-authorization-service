using SyZero.Domain.Entities;
using SyZero.SqlSugar.Repositories;

namespace SyZero.Authorization.Repository
{
    public class AuthorizationRepositoryBase<TEntity> : SqlSugarRepository<AuthorizationDbContext, TEntity>
        where TEntity : class, IEntity, new()
    {
        public AuthorizationRepositoryBase(AuthorizationDbContext dbContext) : base(dbContext)
        {

        }

        //add common methods for all repositories
    }


}



