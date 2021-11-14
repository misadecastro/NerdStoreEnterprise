using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NSE.Carrinho.API.Data;
using System;
using System.IO;

namespace NSE.Carrinho.API.Configuration
{
    public class DesignTimeDbContextFactory
        //: IDesignTimeDbContextFactory<CarrinhoContext>
    {
        
        //public CarrinhoContext CreateDbContext(string[] args)
        //{
        //    var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //    .SetBasePath(Directory.GetCurrentDirectory())
        //    .AddJsonFile($"appsettings.{envName}.json")
        //    .Build();
        //    var builder = new DbContextOptionsBuilder<CarrinhoContext>();
        //    var connectionString = configuration.GetConnectionString("DefaultConnection");
        //    builder.UseSqlServer(connectionString);
        //    return new CarrinhoContext(builder.Options);
        //}
    }
}
