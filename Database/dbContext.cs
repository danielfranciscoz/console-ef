using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HolaMundoORM.Models;

#nullable disable

namespace HolaMundoORM.Database
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCentrosInicio> TbCentrosInicios { get; set; }
        public virtual DbSet<TbConfiguracione> TbConfiguraciones { get; set; }
        public virtual DbSet<TbErrorTest> TbErrorTests { get; set; }
        public virtual DbSet<TbPregunta> TbPreguntas { get; set; }
        public virtual DbSet<TbProtagonista> TbProtagonistas { get; set; }
        public virtual DbSet<TbRespuestasTestVocacional> TbRespuestasTestVocacionals { get; set; }
        public virtual DbSet<TbTestVocacional> TbTestVocacionals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-54RBMT2;Initial Catalog=servicios;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<TbCentrosInicio>(entity =>
            {
                entity.HasKey(e => e.IdCentrosInicio)
                    .HasName("PK__tb_centr__36189A2E984C7F15");

                entity.ToTable("tb_centros_inicio", "portal_vocacional");

                entity.Property(e => e.IdCentrosInicio).HasColumnName("id_centros_inicio");

                entity.Property(e => e.CantidadCarreras).HasColumnName("cantidad_carreras");

                entity.Property(e => e.CantidadLaboratorios).HasColumnName("cantidad_laboratorios");

                entity.Property(e => e.CantidadProtagonistas).HasColumnName("cantidad_protagonistas");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .IsFixedLength(true)
                    .HasComment("'A=Activo' \r\n'I=Inactivo\r\n'P=Publicado'\r\n'E=Eliminado'");

                entity.Property(e => e.FechaGrabacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_grabacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modificacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCentro).HasColumnName("id_centro");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.UsuarioGrabacion).HasColumnName("usuario_grabacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<TbConfiguracione>(entity =>
            {
                entity.HasKey(e => e.IdConfiguracion)
                    .HasName("PK__tb_confi__16A13EBD4A1DD105");

                entity.ToTable("tb_configuraciones", "portal_vocacional");

                entity.Property(e => e.IdConfiguracion).HasColumnName("id_configuracion");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.FechaGrabacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_grabacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modificacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.Property(e => e.UsuarioGrabacion).HasColumnName("usuario_grabacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("valor");

                entity.Property(e => e.ValorVisible)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("valor_visible");
            });

            modelBuilder.Entity<TbErrorTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_error_test", "portal_vocacional");

                entity.Property(e => e.ErrorLine).HasColumnName("error_line");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("error_message");

                entity.Property(e => e.ErrorNumber).HasColumnName("error_number");

                entity.Property(e => e.ErrorProcedure)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("error_procedure");

                entity.Property(e => e.ErrorSeverity).HasColumnName("error_severity");

                entity.Property(e => e.ErrorState).HasColumnName("error_state");

                entity.Property(e => e.FechaError)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_error")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdError)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_error");
            });

            modelBuilder.Entity<TbPregunta>(entity =>
            {
                entity.HasKey(e => e.IdPregunta)
                    .HasName("PK__tb_pregu__6867FFA41F897887");

                entity.ToTable("tb_preguntas", "portal_vocacional");

                entity.Property(e => e.IdPregunta).HasColumnName("id_pregunta");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaGrabacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_grabacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modificacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRubro).HasColumnName("id_rubro");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("pregunta");

                entity.Property(e => e.Puntaje).HasColumnName("puntaje");

                entity.Property(e => e.UsuarioGrabacion).HasColumnName("usuario_grabacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<TbProtagonista>(entity =>
            {
                entity.HasKey(e => e.IdProtagonista)
                    .HasName("PK__tb_prota__2AB5E01581708BCD");

                entity.ToTable("tb_protagonistas", "portal_vocacional");

                entity.Property(e => e.IdProtagonista)
                    .ValueGeneratedNever()
                    .HasColumnName("id_protagonista");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaGrabacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_grabacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modificacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("nombres");

                entity.Property(e => e.Sexo).HasColumnName("sexo");
            });

            modelBuilder.Entity<TbRespuestasTestVocacional>(entity =>
            {
                entity.HasKey(e => e.IdRespuestaTestVocacional)
                    .HasName("PK__tb_respu__AE3B91DA2986B815");

                entity.ToTable("tb_respuestas_test_vocacional", "portal_vocacional");

                entity.Property(e => e.IdRespuestaTestVocacional).HasColumnName("id_respuesta_test_vocacional");

                entity.Property(e => e.FechaGrabacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_grabacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdPregunta).HasColumnName("id_pregunta");

                entity.Property(e => e.IdTestVocacional).HasColumnName("id_test_vocacional");

                entity.Property(e => e.Respuesta).HasColumnName("respuesta");

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.TbRespuestasTestVocacionals)
                    .HasForeignKey(d => d.IdPregunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tb_respue__id_pr__5BE2A6F2");

                entity.HasOne(d => d.IdTestVocacionalNavigation)
                    .WithMany(p => p.TbRespuestasTestVocacionals)
                    .HasForeignKey(d => d.IdTestVocacional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tb_respue__id_te__5CD6CB2B");
            });

            modelBuilder.Entity<TbTestVocacional>(entity =>
            {
                entity.HasKey(e => e.IdTestVocacional)
                    .HasName("PK__tb_test___DCB1C6A04BA7EBE3");

                entity.ToTable("tb_test_vocacional", "portal_vocacional");

                entity.Property(e => e.IdTestVocacional).HasColumnName("id_test_vocacional");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("codigo");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength(true)
                    .HasComment("I=Iniciado\r\nA=Abandonado\r\nF=Finalizado");

                entity.Property(e => e.FechaGrabacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_grabacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modificacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdProtagonista).HasColumnName("id_protagonista");

                entity.HasOne(d => d.IdProtagonistaNavigation)
                    .WithMany(p => p.TbTestVocacionals)
                    .HasForeignKey(d => d.IdProtagonista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tb_test_v__id_pr__5812160E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
