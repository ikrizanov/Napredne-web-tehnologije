using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NWT_Seminar.Models;

namespace NWT_Seminar.DAL
{
    public class NWT_SeminarContext : DbContext
    {
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Film> Filmovi { get; set; }

        public DbSet<Scenarist> Scenaristi { get; set; }

        public DbSet<Redatelj> Redatelji { get; set; }
        public DbSet<Glumac> Glumci { get; set; }
    }
}