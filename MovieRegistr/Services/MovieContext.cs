using Microsoft.EntityFrameworkCore;
using MovieRegistr.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistr.Services
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<MovieDAL> Movies { get; set; }

    }
}
