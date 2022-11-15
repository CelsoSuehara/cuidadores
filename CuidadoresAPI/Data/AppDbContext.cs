using CuidadoresAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CuidadoresAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(45);
                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(45);
                entity.Property(e => e.Nome)
                    .HasMaxLength(45);
                entity.Property(e => e.Telefone);
            });

            builder.Entity<Idoso>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.IdUsuario);
                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(45);
                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1);
                entity.Property(e => e.DataNascimento);
                entity.Property(e => e.Necessidades)
                    .IsRequired()
                    .HasMaxLength(500);
                entity.Property(e => e.Logradouro);
                entity.Property(e => e.Numero);
                entity.Property(e => e.Bairro);
                entity.Property(e => e.Cidade);
                entity.Property(e => e.Estado);
                entity.Property(e => e.Cep);
            });

            builder.Entity<Cuidador>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(45);
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(45);
                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(45);
                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1);
                entity.Property(e => e.DataNascimento);
                entity.Property(e => e.Especialidades)
                    .IsRequired()
                    .HasMaxLength(500);
                entity.Property(e => e.Logradouro);
                entity.Property(e => e.Numero);
                entity.Property(e => e.Bairro);
                entity.Property(e => e.Cidade);
                entity.Property(e => e.Estado);
                entity.Property(e => e.Cep);
                entity.Property(e => e.Telefone);
            });

            builder.Entity<Servico>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.IdIdoso);
                entity.Property(e => e.IdCuidador);
                entity.Property(e => e.DataHoraInicio);
                entity.Property(e => e.DataHoraFim);
                entity.Property(e => e.Valor);
                entity.Property(e => e.Observacoes)
                    .IsRequired()
                    .HasMaxLength(500);
            });
        }

        public DbSet<Cuidador> Cuidadores { get; set; }
        public DbSet<Idoso> Idosos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
