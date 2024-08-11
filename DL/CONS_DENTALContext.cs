using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DL
{
    public partial class CONS_DENTALContext : DbContext
    {
        public CONS_DENTALContext()
        {
        }

        public CONS_DENTALContext(DbContextOptions<CONS_DENTALContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnteFam> AnteFams { get; set; } = null!;
        public virtual DbSet<AnteHeredoFam> AnteHeredoFams { get; set; } = null!;
        public virtual DbSet<AnteNoPatoPer> AnteNoPatoPers { get; set; } = null!;
        public virtual DbSet<AntePato> AntePatos { get; set; } = null!;
        public virtual DbSet<AntePer> AntePers { get; set; } = null!;
        public virtual DbSet<AntePersPato> AntePersPatos { get; set; } = null!;
        public virtual DbSet<ExamComplementario> ExamComplementarios { get; set; } = null!;
        public virtual DbSet<ExamIntrabucal> ExamIntrabucals { get; set; } = null!;
        public virtual DbSet<ExamOclusion> ExamOclusions { get; set; } = null!;
        public virtual DbSet<Exploracion> Exploracions { get; set; } = null!;
        public virtual DbSet<HistoriaClinica> HistoriaClinicas { get; set; } = null!;
        public virtual DbSet<Paciente> Pacientes { get; set; } = null!;
        public virtual DbSet<TipoExamCompl> TipoExamCompls { get; set; } = null!;
        public virtual DbSet<TipoMordidum> TipoMordida { get; set; } = null!;
        public virtual DbSet<Tratamiento> Tratamientos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8L72BRD; Database= CONS_DENTAL; Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true; User ID=sa; Password=1234567890;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnteFam>(entity =>
            {
                entity.HasKey(e => e.IdAnteFam)
                    .HasName("PK__AnteFam__0164C3E00B5AD2F0");

                entity.ToTable("AnteFam");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnteHeredoFam>(entity =>
            {
                entity.HasKey(e => e.IdAnteHeredoFam)
                    .HasName("PK__AnteHere__EE05AF01D4DA8FD9");

                entity.ToTable("AnteHeredoFam");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAnteFamNavigation)
                    .WithMany(p => p.AnteHeredoFams)
                    .HasForeignKey(d => d.IdAnteFam)
                    .HasConstraintName("FK__AnteHered__IdAnt__3F466844");

                entity.HasOne(d => d.IdHistoriaClinicaNavigation)
                    .WithMany(p => p.AnteHeredoFams)
                    .HasForeignKey(d => d.IdHistoriaClinica)
                    .HasConstraintName("FK__AnteHered__IdHis__3E52440B");
            });

            modelBuilder.Entity<AnteNoPatoPer>(entity =>
            {
                entity.HasKey(e => e.IdAnteNoPatoPers)
                    .HasName("PK__AnteNoPa__8607C791BA910B7C");

                entity.HasOne(d => d.IdAntePersNavigation)
                    .WithMany(p => p.AnteNoPatoPers)
                    .HasForeignKey(d => d.IdAntePers)
                    .HasConstraintName("FK__AnteNoPat__IdAnt__44FF419A");

                entity.HasOne(d => d.IdHistoriaClinicaNavigation)
                    .WithMany(p => p.AnteNoPatoPers)
                    .HasForeignKey(d => d.IdHistoriaClinica)
                    .HasConstraintName("FK__AnteNoPat__IdHis__440B1D61");
            });

            modelBuilder.Entity<AntePato>(entity =>
            {
                entity.HasKey(e => e.IdAntePato)
                    .HasName("PK__AntePato__21ED675FAD63C950");

                entity.ToTable("AntePato");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AntePer>(entity =>
            {
                entity.HasKey(e => e.IdAntePers)
                    .HasName("PK__AntePers__22E5871200A97D10");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AntePersPato>(entity =>
            {
                entity.HasKey(e => e.IdAntePersPato)
                    .HasName("PK__AntePers__DD50A55D2F28F2AA");

                entity.ToTable("AntePersPato");

                entity.Property(e => e.Respuesta)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAntePatoNavigation)
                    .WithMany(p => p.AntePersPatos)
                    .HasForeignKey(d => d.IdAntePato)
                    .HasConstraintName("FK__AntePersP__IdAnt__4AB81AF0");

                entity.HasOne(d => d.IdHistoriaClinicaNavigation)
                    .WithMany(p => p.AntePersPatos)
                    .HasForeignKey(d => d.IdHistoriaClinica)
                    .HasConstraintName("FK__AntePersP__IdHis__49C3F6B7");
            });

            modelBuilder.Entity<ExamComplementario>(entity =>
            {
                entity.HasKey(e => e.IdExamComplementario)
                    .HasName("PK__ExamComp__9D140D939DD574AB");

                entity.ToTable("ExamComplementario");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Imagen).IsUnicode(false);

                entity.HasOne(d => d.IdHistoriaClinicaNavigation)
                    .WithMany(p => p.ExamComplementarios)
                    .HasForeignKey(d => d.IdHistoriaClinica)
                    .HasConstraintName("FK__ExamCompl__IdHis__5DCAEF64");

                entity.HasOne(d => d.IdTipoExamComplNavigation)
                    .WithMany(p => p.ExamComplementarios)
                    .HasForeignKey(d => d.IdTipoExamCompl)
                    .HasConstraintName("FK__ExamCompl__IdTip__5EBF139D");
            });

            modelBuilder.Entity<ExamIntrabucal>(entity =>
            {
                entity.HasKey(e => e.IdExamIntrabucal)
                    .HasName("PK__ExamIntr__FD2AA223C421B94F");

                entity.ToTable("ExamIntrabucal");

                entity.Property(e => e.Carrillos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Encia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lengua)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mucosa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paladar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdHistoriaClinicaNavigation)
                    .WithMany(p => p.ExamIntrabucals)
                    .HasForeignKey(d => d.IdHistoriaClinica)
                    .HasConstraintName("FK__ExamIntra__IdHis__534D60F1");
            });

            modelBuilder.Entity<ExamOclusion>(entity =>
            {
                entity.HasKey(e => e.IdExamOclusion)
                    .HasName("PK__ExamOclu__4204D699DF3780FB");

                entity.ToTable("ExamOclusion");

                entity.Property(e => e.AlteraFormNumEstru)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Apinamiento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClasAnguloL)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ClasAngulo_L");

                entity.Property(e => e.ClasAnguloR)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ClasAngulo_R");

                entity.Property(e => e.Diastemas)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Erupcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LineaMedia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlanoTerminalL)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PlanoTerminal_L");

                entity.Property(e => e.PlanoTerminalR)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PlanoTerminal_R");

                entity.Property(e => e.RelaAnt)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RelaCanL)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RelaCan_L");

                entity.Property(e => e.RelaCanR)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RelaCan_R");

                entity.Property(e => e.TipoDenticion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tremas)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VersDentarias)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdHistoriaClinicaNavigation)
                    .WithMany(p => p.ExamOclusions)
                    .HasForeignKey(d => d.IdHistoriaClinica)
                    .HasConstraintName("FK__ExamOclus__IdHis__5812160E");

                entity.HasOne(d => d.IdTipoMordidaNavigation)
                    .WithMany(p => p.ExamOclusions)
                    .HasForeignKey(d => d.IdTipoMordida)
                    .HasConstraintName("FK__ExamOclus__IdTip__59063A47");
            });

            modelBuilder.Entity<Exploracion>(entity =>
            {
                entity.HasKey(e => e.IdExploracion)
                    .HasName("PK__Explorac__036128CA50C40079");

                entity.ToTable("Exploracion");

                entity.Property(e => e.AspcPac)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Atm)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ATM");

                entity.Property(e => e.Fc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FC");

                entity.Property(e => e.Fr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FR");

                entity.Property(e => e.LabiosComisuras)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegionHyT)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ta)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TA");

                entity.Property(e => e.Temperatura)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdHistoriaClinicaNavigation)
                    .WithMany(p => p.Exploracions)
                    .HasForeignKey(d => d.IdHistoriaClinica)
                    .HasConstraintName("FK__Exploraci__IdHis__4D94879B");
            });

            modelBuilder.Entity<HistoriaClinica>(entity =>
            {
                entity.HasKey(e => e.IdHistoriaClinica)
                    .HasName("PK__Historia__36B024BCDC98891C");

                entity.ToTable("HistoriaClinica");

                entity.Property(e => e.Consentimiento).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente)
                    .HasName("PK__Paciente__C93DB49B7B427ED9");

                entity.ToTable("Paciente");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Genero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ocupacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdHistoriaClinicaNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdHistoriaClinica)
                    .HasConstraintName("FK__Paciente__IdHist__5070F446");
            });

            modelBuilder.Entity<TipoExamCompl>(entity =>
            {
                entity.HasKey(e => e.IdTipoExamCompl)
                    .HasName("PK__TipoExam__B66AB87EC11BFB19");

                entity.ToTable("TipoExamCompl");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoMordidum>(entity =>
            {
                entity.HasKey(e => e.IdTipoMordida)
                    .HasName("PK__TipoMord__F2749DD096BA661A");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tratamiento>(entity =>
            {
                entity.HasKey(e => e.IdTratamiento)
                    .HasName("PK__Tratamie__5CB7E7534740C57A");

                entity.ToTable("Tratamiento");

                entity.Property(e => e.Estatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaUltimaVisita).HasColumnType("date");

                entity.Property(e => e.OrganoDentario)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Procedimiento)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdHistoriaClinicaNavigation)
                    .WithMany(p => p.Tratamientos)
                    .HasForeignKey(d => d.IdHistoriaClinica)
                    .HasConstraintName("FK__Tratamien__IdHis__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
