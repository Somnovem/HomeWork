using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_ChessDb
{
    internal class ContestantConfiguration : EntityTypeConfiguration<Contestant>
    {
        public ContestantConfiguration()
        {
            this.HasKey(e => e.Id);
            Property(e => e.Id)
                    .HasColumnType("int")
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Firtsname)
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(p => p.Lastname)
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(p => p.Birthdate)
                .HasColumnType("date")
                .IsRequired();

            Property(p => p.Country)
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(e => e.Rank)
                    .HasColumnType("int")
                    .IsRequired();
            ToTable("Contestants");
        }
    }
    internal class TournamentConfiguration : EntityTypeConfiguration<Tournament>
    {
        public TournamentConfiguration()
        {
            this.HasKey(e => e.Id);
            Property(e => e.Id)
                    .HasColumnType("int")
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar")
                    .IsRequired();
            Property(p => p.StartDate)
                    .HasColumnType("date")
                    .IsRequired();
            Property(p => p.EndDate)
                    .HasColumnType("date")
                    .IsRequired();
            Property(p => p.Prize)
                    .HasColumnType("money")
                    .IsRequired();
            ToTable("Tournaments");
        }
    }
    internal class ResultConfiguration : EntityTypeConfiguration<Result>
    {
        public ResultConfiguration()
        {
            this.HasKey(e => e.Id);
            Property(e => e.Id)
                    .HasColumnType("int")
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(i => i.TournamentId)
                    .HasColumnType("int")
                    .IsRequired();
            Property(i => i.WinnerId)
                    .HasColumnType("int")
                    .IsRequired();
            ToTable("Results");
        }
    }
    internal class TournamentContestantConfiguration : EntityTypeConfiguration<TournamentContestant>
    {
        public TournamentContestantConfiguration()
        {
            this.HasKey(e => e.Id);
            Property(e => e.Id)
                    .HasColumnType("int")
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(i => i.Tournament_Id)
                    .HasColumnType("int")
                    .IsRequired();
            Property(i => i.Contestant_Id)
                    .HasColumnType("int")
                    .IsRequired();
            ToTable("TournamentContestants");
        }
    }
}
