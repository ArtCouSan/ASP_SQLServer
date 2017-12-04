using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class contexto: DbContext
    {
        public DbSet<Serie> Series { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Anime> Animes { get; set; }
    }
}