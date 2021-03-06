using AssigmentAPI.DataAccess.Concrate.EntityFramework.Mappings;
using AssigmentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace AssigmentAPI.DataAccess.Concrate.EntityFramework
{
    public class AssigmentContext : DbContext
    {
        public AssigmentContext()
        {
            Database.SetInitializer<AssigmentContext>(null);
        }

        public DbSet<PrimeNumber> IntegerNumbers { get; set; }
        public DbSet<TurkishAlphabetCharacter> TurkishAlphabetCharacters { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PrimeNumberMap());
            modelBuilder.Configurations.Add(new TurkishAlphabetCharacterMap());

        }
    }
}
