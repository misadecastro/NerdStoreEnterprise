using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NSE.Pedidos.Infra.Data;
using System;
using System.IO;

namespace NSE.Pedidos.API.Configuration
{
    public class DesignTimeDbContextFactory
    //: IDesignTimeDbContextFactory<PedidosContext>
    {

        //public PedidosContext CreateDbContext(string[] args)
        //{
        //    var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //    .SetBasePath(Directory.GetCurrentDirectory())
        //    .AddJsonFile($"appsettings.{envName}.json")
        //    .Build();
        //    var builder = new DbContextOptionsBuilder<PedidosContext>();
        //    var connectionString = configuration.GetConnectionString("DefaultConnection");
        //    builder.UseSqlServer(connectionString);
        //    return new PedidosContext(builder.Options);
        //}
    }
}
