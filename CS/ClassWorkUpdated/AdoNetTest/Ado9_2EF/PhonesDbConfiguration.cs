using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado9_2EF
{
    internal class ManufacturerConfiguration : EntityTypeConfiguration<Manufacturer>
    {
        public ManufacturerConfiguration()
        {
            // составной первичный ключ
            // HasKey(p => new { p.Id, p.FullName });

            // установить первичный ключ, колонка Id
            HasKey(e => e.Id);
            Property(i => i.Id)
                // название колонки в таблице БД
                .HasColumnName("id")
                // тип данных 'int' для колонки Id в БД
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.FullName)
                .HasColumnName("name")
                // размер колонки
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                // обязательное поле
                .IsRequired();

            Property(p => p.Country)
                            .HasColumnName("country")
                            .HasMaxLength(100)
                            .HasColumnType("nvarchar")
                            .IsRequired();

            Property(p => p.Capital)
                            .HasColumnName("capital")
                            .HasColumnType("money")
                            // задать точность для вещественных чисел
                            //.HasPrecision(14, 5)
                            .IsRequired();

            Property(p => p.Owner)
                            .HasColumnName("owner")
                            .HasMaxLength(200)
                            .HasColumnType("nvarchar")
                            .IsRequired();

            // не добавлять колонку в БД
            Ignore(p => p.NameAndOwner);

            // для таблицы задать имя
            ToTable("Manufacturers");

            // переопределение удаления, с помощью хранимой процедуры, файл dbo.Procedure.sql
            MapToStoredProcedures(
                d => d.Delete(sp => sp.HasName("DeleteManufacturer")
                .Parameter(pm => pm.Id, "Id"))
                );
        }
    }
    internal class PhoneConfiguration : EntityTypeConfiguration<Phone>
    {
        public PhoneConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Id)
                // название колонки в таблице БД
                .HasColumnName("id")
                // тип данных 'int' для колонки Id в БД
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                // размер колонки
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                // обязательное поле
                .IsRequired()
                .IsUnicode()
                .IsVariableLength();

            Property(p => p.MemorySize)
                            .HasPrecision(14, 1)
                            .IsRequired();

            Property(p => p.Color)
                // размер колонки
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                // обязательное поле
                .IsRequired()
                .IsVariableLength();

            Property(p => p.DateOfIssue)
                .HasColumnType("date")
                // обязательное поле
                .IsRequired();

            Property(p => p.OSName)
                // размер колонки
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                // поле не обязательное
                .IsOptional();

            Property(p => p.ManufacturerId)
                // тип данных 'int' для колонки Id в БД
                .HasColumnType("int")
                .IsRequired();

            // для таблицы задать имя
            ToTable("Phones");
        }
    }
}