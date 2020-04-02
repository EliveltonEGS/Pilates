using Microsoft.EntityFrameworkCore;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base (options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Agenda>().HasKey(x => x.AngendaId);
            builder.Entity<Aluno>().HasKey(x => x.AlunoId);
            builder.Entity<Aparelho>().HasKey(x => x.AparelhoId);
            builder.Entity<Aula>().HasKey(x => x.AulaId);
            builder.Entity<Cidade>().HasKey(x => x.CidadeId);
            builder.Entity<ContasPagar>().HasKey(x => x.ContasPagarId);
            builder.Entity<Endereco>().HasKey(x => x.EnderecoId);
            builder.Entity<Especialidade>().HasKey(x => x.EspecialidadeId);
            builder.Entity<Exercicio>().HasKey(x => x.ExercicioId);
            builder.Entity<FormaPagamento>().HasKey(x => x.FormaPagamentoId);
            builder.Entity<Matricula>().HasKey(x => x.MatriculaId);
            builder.Entity<Professor>().HasKey(x => x.ProfessorId);
            builder.Entity<Sala>().HasKey(x => x.SalaId);
        }

        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Aparelho> Aparelhos { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<ContasPagar> ContasPagar { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Sala> Salas { get; set; }
    }
}
