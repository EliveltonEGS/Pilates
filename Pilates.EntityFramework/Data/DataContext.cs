using Microsoft.EntityFrameworkCore;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base (options) { }

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
