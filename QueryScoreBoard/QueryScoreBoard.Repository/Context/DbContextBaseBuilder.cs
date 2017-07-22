using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Devart.Data.Oracle;
using System.Data;


namespace QueryScoreBoard.Repository.Context
{
    public class DbContextBaseBuilder
    {
        private readonly DbContextOptionsBuilder<DbContext> _builder;

        public DbContextBaseBuilder()
        {
            _builder = new DbContextOptionsBuilder<DbContext>();
        }

        public DbContextBaseBuilder ConnectionString(string connectionString)
        {
            _builder.UseOracle(connectionString);
            return this;
        }

        public DbContextOptions Build()
        {
            return _builder.Options;
        }
    }
}
