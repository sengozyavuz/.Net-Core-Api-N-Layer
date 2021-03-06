using AssigmentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace AssigmentAPI.DataAccess.Concrate.EntityFramework.Mappings
{
    public class TurkishAlphabetCharacterMap : EntityTypeConfiguration<TurkishAlphabetCharacter>
    {
        public TurkishAlphabetCharacterMap()
        {
            ToTable(@"UserRoles", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Character).HasColumnName("Character");
        }
    }
}
