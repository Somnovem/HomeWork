using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagerDb
{
    internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(c => c.Id);


            builder.Property(c => c.Firstname)
                   .IsRequired().IsUnicode().HasMaxLength(50);
            builder.Property(c => c.Lastname)
                 .IsRequired().IsUnicode().HasMaxLength(50);
            builder.Property(c => c.Birthday)
                  .IsRequired().HasDefaultValueSql("getdate()");
            builder.Property(c => c.Email)
                  .IsRequired().HasMaxLength(100);
            builder.Property(c => c.Desctiption)
                   .IsRequired(false).IsUnicode().HasMaxLength(100);
            builder.ToTable(c => c.HasCheckConstraint("CK_Firstname", "Firstname <> ''"));
            builder.ToTable(c => c.HasCheckConstraint("CK_Lastname", "Lastname <> ''"));
        }
    }
    internal class MessageHistoryConfiguration : IEntityTypeConfiguration<MessageHistory>
    {
        public void Configure(EntityTypeBuilder<MessageHistory> builder)
        {
            builder.ToTable("Messages");
            builder.HasKey(m => m.Id);

            builder.Property(m => m.DateOf)
                   .IsRequired().HasDefaultValueSql("getdate()");
            builder.Property(c => c.Message)
                   .IsRequired().IsUnicode().HasMaxLength(500);
        }
    }
}
