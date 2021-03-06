﻿using Microsoft.Extensions.Configuration;
using System.IO;

namespace DDD.Infra.Data.Sql.Data
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            ConnectionString = root.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            var appSetting = root.GetSection("ApplicationSettings");
        }

        public string ConnectionString { get; } = string.Empty;

    }
}
