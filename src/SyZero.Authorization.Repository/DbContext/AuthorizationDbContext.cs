
using SqlSugar;
using System;
using SyZero.SqlSugar.DbContext;

namespace SyZero.Authorization.Repository
{
    public class AuthorizationDbContext : SyZeroDbContext
    {
        public AuthorizationDbContext(ConnectionConfig config) : base(config)
        {

        }
    }
}



