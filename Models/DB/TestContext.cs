using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ODataAlternateKeySample.Models.DB
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LogTable> LogTables { get; set; }
        public virtual DbSet<LoggerDb> LoggerDbs { get; set; }
        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Test;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogTable");

                entity.Property(e => e.CIp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cIp");

                entity.Property(e => e.CsBytes).HasColumnName("csBytes");

                entity.Property(e => e.CsCookie)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("csCookie");

                entity.Property(e => e.CsHost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("csHost");

                entity.Property(e => e.CsMethod)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("csMethod");

                entity.Property(e => e.CsReferer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("csReferer");

                entity.Property(e => e.CsUriQuery)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("csUriQuery");

                entity.Property(e => e.CsUriStem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("csUriStem");

                entity.Property(e => e.CsUserAgent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("csUserAgent");

                entity.Property(e => e.CsUsername)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("csUsername");

                entity.Property(e => e.CsVersion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("csVersion");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.LogFilename)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SActiveProcs).HasColumnName("sActiveProcs");

                entity.Property(e => e.SComputername)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sComputername");

                entity.Property(e => e.SEvent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sEvent");

                entity.Property(e => e.SIp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sIp");

                entity.Property(e => e.SKernelTime).HasColumnName("sKernelTime");

                entity.Property(e => e.SPageFaults).HasColumnName("sPageFaults");

                entity.Property(e => e.SPort).HasColumnName("sPort");

                entity.Property(e => e.SProcessType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sProcessType");

                entity.Property(e => e.SSitename)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sSitename");

                entity.Property(e => e.SStoppedProcs).HasColumnName("sStoppedProcs");

                entity.Property(e => e.STotalProcs).HasColumnName("sTotalProcs");

                entity.Property(e => e.SUserTime).HasColumnName("sUserTime");

                entity.Property(e => e.ScBytes).HasColumnName("scBytes");

                entity.Property(e => e.ScStatus).HasColumnName("scStatus");

                entity.Property(e => e.ScSubstatus).HasColumnName("scSubstatus");

                entity.Property(e => e.ScWin32Status).HasColumnName("scWin32Status");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.TimeTaken).HasColumnName("timeTaken");
            });

            modelBuilder.Entity<LoggerDb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LoggerDB");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasMaxLength(4000);

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Message).HasMaxLength(150);

                entity.Property(e => e.RawException).HasMaxLength(4000);

                entity.Property(e => e.RawRequest).HasMaxLength(4000);

                entity.Property(e => e.RawResponse).HasMaxLength(4000);

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.UserName).HasMaxLength(250);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Test");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
