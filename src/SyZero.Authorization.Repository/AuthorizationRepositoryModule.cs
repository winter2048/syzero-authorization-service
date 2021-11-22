using Autofac;
using SyZero.Domain.Repository;
using SyZero.SqlSugar;

namespace SyZero.Authorization.Repository
{
    public class AuthorizationRepositoryModule : Module
    {
        public AuthorizationRepositoryModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            // 首先注册 options，供 DbContext 服务初始化使用
            builder.AddSyZeroSqlSugar<AuthorizationDbContext>();
            //注册仓储泛型
            builder.RegisterGeneric(typeof(AuthorizationRepositoryBase<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope().PropertiesAutowired();
            ////注册持久化
            builder.RegisterType<UnitOfWork<AuthorizationDbContext>>().As<IUnitOfWork>().InstancePerLifetimeScope().PropertiesAutowired();

        }
    }
}



