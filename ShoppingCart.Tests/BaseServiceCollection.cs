using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ShoppingCartTest
{
    public abstract class BaseServiceCollection<TContext> where TContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        private IServiceCollection _ServiceCollection;

        public IServiceCollection ServiceCollection => _ServiceCollection;


        public IServiceCollection CreateDBContext()
        {
            //allows for the switching between various data persisting technologies
            return CreateInMemoryDBContext();
        }


        private IServiceCollection CreateInMemoryDBContext()
        {
            _ServiceCollection = new ServiceCollection()
                                .AddDbContext<TContext>(options => options
                                                         .UseInMemoryDatabase(Guid.NewGuid().ToString())
                                                         .EnableSensitiveDataLogging());

            return _ServiceCollection;
        }

        private IServiceCollection CreateSQLLiteDBContext()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = ":memory:" };
            var connectionString = connectionStringBuilder.ToString();

            var connection = new SqliteConnection(connectionString);

            _ServiceCollection = new ServiceCollection()
                                .AddDbContext<TContext>(options => options
                                                         .UseSqlite(connection)
                                                         .EnableSensitiveDataLogging());
            return _ServiceCollection;
        }
    }
}
