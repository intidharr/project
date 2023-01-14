﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Projet.Models;

namespace Projet.Data
{
    public class LibraryContext : DbContext
    {
        private static  LibraryContext _context = null;
        public DbSet<Book> Book { get; set; }
        public DbSet<Client>Client { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Emprunt> Emprunt { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emprunt>()
                .HasKey(e => new { e.id_book, e.Inscription_Id });
        }

        private LibraryContext(DbContextOptions o) : base(o)
        { 
        
        }

        public static LibraryContext Instantiate_LibraryContext()
        {
            try
            {
                
                if (_context == null)
                {
                    
                    var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
                    optionsBuilder.UseSqlite(@"Data Source=C:\Users\sourour\Downloads\sqLite (2).db");

                    _context = new LibraryContext(optionsBuilder.Options);
                }

                return _context;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("un exception est trouvee" + ex.Message);
            }
            return _context;
        }

    }
}
