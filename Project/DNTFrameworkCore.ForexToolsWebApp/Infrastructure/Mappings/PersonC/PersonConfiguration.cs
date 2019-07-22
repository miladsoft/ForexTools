using Microsoft.EntityFrameworkCore;
using DNTFrameworkCore.ForexToolsWebApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNTFrameworkCore.ForexToolsWebApp.Infrastructure.Mappings.PersonC
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(b => b.Name).IsRequired().HasMaxLength(Person.MaxTitleLength);
            builder.Property(b => b.NormalizedName).IsRequired().HasMaxLength(Person.MaxTitleLength);

            builder.HasIndex(b => b.NormalizedName).HasName("Person_NormalizedName").IsUnique();
        }
    }
}
