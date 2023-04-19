using System;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

using System.Collections.Generic;


namespace AppConDataBaseSqlLite
{
	public class ContextManager : DbContext
    {
        public DbSet<Persona> Persona { get; set; }

        public string DbPath { get; }


        public ContextManager()
		{
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "persone.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}




