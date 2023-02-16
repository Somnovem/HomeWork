using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesDb
{
    internal class ManufacturerConfiguration : EntityTypeConfiguration<Manufacturer>
    {
        public ManufacturerConfiguration()
        {
            //составной первичный ключ
            //HasKey(p => new { p.Id, p.Fullname });


            this.HasKey(e => e.Id);

            Property(i => i.Id)
                .HasColumnName("id") //optional changing the name in the db(if want it to be the same as in Class, do not use this)
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Fullname)
                .HasColumnName("name")
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(p => p.Country)
                .HasColumnName("country")
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(c => c.Capital)
                .HasColumnName("capital")
                .HasColumnType("money")
                //.HasPrecision(3)//для чисел с плавающей точкой
                .IsRequired();

            Property(p => p.Owner)
                .HasColumnName("owner")
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                .IsRequired();


            Ignore(c => c.NameAndOwner);//to ignore property on creaing the db

            //give the table a name
            ToTable("Manufacturers");
        }
    }
    internal class PhoneConfiguration : EntityTypeConfiguration<Phone>
    {
        public PhoneConfiguration()
        {
            this.HasKey(p => p.Id);
            Property(i => i.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                .IsRequired()
                .IsUnicode()
                .IsVariableLength();

            Property(c => c.MemorySize)
                .HasColumnType("decimal")
                .HasPrecision(14, 1)
                .IsRequired();

            Property(p => p.Color)
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(p => p.OSName)
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                .IsOptional(); // not required

            Property(p => p.Release)
                .HasColumnType("date")
                .IsRequired();

            Property(i => i.ManufacturerId)
                .HasColumnType("int")
                .IsRequired();

            ToTable("Phones");
        }
    }
}
