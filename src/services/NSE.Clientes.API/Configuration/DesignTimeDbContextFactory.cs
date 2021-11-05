using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NSE.Clientes.API.Data;
using System;
using System.IO;

namespace NSE.Clientes.API.Configuration
{
    public class DesignTimeDbContextFactory 
        //: IDesignTimeDbContextFactory<ClientesContext>
    {
        /*
        public ClientesContext CreateDbContext(string[] args)
        {
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"appsettings.{envName}.json")
            .Build();
            var builder = new DbContextOptionsBuilder<ClientesContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new ClientesContext(builder.Options);
        }*/
    }
}
