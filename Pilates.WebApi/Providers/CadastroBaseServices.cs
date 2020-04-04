using Microsoft.Extensions.DependencyInjection;
using Pilates.Adapter.Map.CadastroBaseAgenda;
using Pilates.Adapter.Map.CadastroBaseAluno;
using Pilates.Adapter.Map.CadastroBaseAparelho;
using Pilates.Adapter.Map.CadastroBaseAula;
using Pilates.Adapter.Map.CadastroBaseCidade;
using Pilates.Adapter.Map.CadastroBaseContasPagar;
using Pilates.Adapter.Map.CadastroBaseEndereco;
using Pilates.Adapter.Map.CadastroBaseEspecialidade;
using Pilates.Adapter.Map.CadastroBaseExercicio;
using Pilates.Adapter.Map.CadastroBaseFormaPagamento;
using Pilates.Adapter.Map.CadastroBaseMatricula;
using Pilates.Adapter.Map.CadastroBaseModalidade;
using Pilates.Adapter.Map.CadastroBaseProfessor;
using Pilates.Adapter.Map.CadastroBaseSala;
using Pilates.Application.Services.Agenda;
using Pilates.Application.Services.Aluno;
using Pilates.Application.Services.Aparelho;
using Pilates.Application.Services.Aula;
using Pilates.Application.Services.Cidade;
using Pilates.Application.Services.ContasPagar;
using Pilates.Application.Services.Endereco;
using Pilates.Application.Services.Especialidade;
using Pilates.Application.Services.Exercicio;
using Pilates.Application.Services.FormaPagamento;
using Pilates.Application.Services.Matricula;
using Pilates.Application.Services.Modalidade;
using Pilates.Application.Services.Professor;
using Pilates.Application.Services.Sala;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAgenda;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAluno;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAparelho;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAula;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseCidade;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseEndereco;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseEspecialidade;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseFormaPagamento;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseMatricula;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseModalidade;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseProfessor;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseSala;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadstroBaseExercicio;
using Pilates.EntityFramework.Repositorys.CadastroBase.CasdastroBaseContasPagar;
using Pilates.Service.Services.CadastroBase.CadastroBaseAgenda;
using Pilates.Service.Services.CadastroBase.CadastroBaseAluno;
using Pilates.Service.Services.CadastroBase.CadastroBaseAparelho;
using Pilates.Service.Services.CadastroBase.CadastroBaseAula;
using Pilates.Service.Services.CadastroBase.CadastroBaseCidade;
using Pilates.Service.Services.CadastroBase.CadastroBaseContasPagar;
using Pilates.Service.Services.CadastroBase.CadastroBaseEndereco;
using Pilates.Service.Services.CadastroBase.CadastroBaseEspecialidade;
using Pilates.Service.Services.CadastroBase.CadastroBaseExercicio;
using Pilates.Service.Services.CadastroBase.CadastroBaseFormaPagamento;
using Pilates.Service.Services.CadastroBase.CadastroBaseMatricula;
using Pilates.Service.Services.CadastroBase.CadastroBaseModalidade;
using Pilates.Service.Services.CadastroBase.CadastroBaseProfessor;
using Pilates.Service.Services.CadastroBase.CadastroBaseSala;

namespace Pilates.WebApi.Providers
{
    public static class CadastroBaseServices
    {
        public static void AddCadastroBaseServices(this IServiceCollection services)
        {
            //Serviços de Aplicação
            services.AddScoped<IApplicationServiceAgenda, ApplicationServiceAgenda>();
            services.AddScoped<IApplicationServiceAluno, ApplicationServiceAluno>();
            services.AddScoped<IApplicationServiceAparelho, ApplicationServiceAparelho>();
            services.AddScoped<IApplicationServiceAula, ApplicationServiceAula>();
            services.AddScoped<IApplicationServiceCidade, ApplicationServiceCidade>();
            services.AddScoped<IApplicationServiceContasPagar, ApplicationServiceContasPagar>();
            services.AddScoped<IApplicationServiceEndereco, ApplicationServiceEndereco>();
            services.AddScoped<IApplicationServiceEspecialidade, ApplicationServiceEspecialidade>();
            services.AddScoped<IApplicationServiceExercicio, ApplicationServiceExercicio>();
            services.AddScoped<IApplicationServiceFormaPagamento, ApplicationServiceFormaPagamento>();
            services.AddScoped<IApplicationServiceMatricula, ApplicationServiceMatricula>();
            services.AddScoped<IApplicationServiceModalidade, ApplicationServiceModalidade>();
            services.AddScoped<IApplicationServiceProfessor, ApplicationServiceProfessor>();
            services.AddScoped<IApplicationServiceSala, ApplicationServiceSala>();

            //Serviços Crud
            services.AddScoped<IServiceAgenda, ServiceAgenda>();
            services.AddScoped<IServiceAluno, ServiceAluno>();
            services.AddScoped<IServiceAparelho, ServiceAparelho>();
            services.AddScoped<IServiceAula, ServiceAula>();
            services.AddScoped<IServiceCidade, ServiceCidade>();
            services.AddScoped<IServiceContasPagar, ServiceContasPagar>();
            services.AddScoped<IServiceEndereco, ServiceEndereco>();
            services.AddScoped<IServiceEspecialidade, ServiceEspecialidade>();
            services.AddScoped<IServiceExercicio, ServiceExercicio>();
            services.AddScoped<IServiceFormaPagamento, ServiceFormaPagamento>();
            services.AddScoped<IServiceMatricula, ServiceMatricula>();
            services.AddScoped<IServiceModalidade, ServiceModalidade>();
            services.AddScoped<IServiceProfessor, ServiceProfessor>();
            services.AddScoped<IServiceSala, ServiceSala>();

            //Repositórios
            services.AddScoped<IRepositoryAgenda, RepositoryAgenda>();
            services.AddScoped<IRepositoryAluno, RepositoryAluno>();
            services.AddScoped<IRepositoryAparelho, RepositoryAparelho>();
            services.AddScoped<IRepositoryAula, RepositoryAula>();
            services.AddScoped<IRepositoryCidade, RepositoryCidade>();
            services.AddScoped<IRepositoryContasPagar, RepositoryContasPagar>();
            services.AddScoped<IRepositoryEndereco, RepositoryEndereco>();
            services.AddScoped<IRepositoryEspecialidade, RepositoryEspecialidade>();
            services.AddScoped<IRepositoryExercicio, RepositoryExercicio>();
            services.AddScoped<IRepositoryFormaPagamento, RepositoryFormaPagamento>();
            services.AddScoped<IRepositoryMatricula, RepositoryMatricula>();
            services.AddScoped<IRepositoryModalidade, RepositoryModalidade>();
            services.AddScoped<IRepositoryProfessor, RepositoryProfessor>();
            services.AddScoped<IRepositorySala, RepositorySala>();

            //Adapters
            services.AddScoped<IMapperAgenda, MapperAgenda>();
            services.AddScoped<IMapperAluno, MapperAluno>();
            services.AddScoped<IMapperAparelho, MapperAparelho>();
            services.AddScoped<IMapperAula, MapperAula>();
            services.AddScoped<IMapperCidade, MapperCidade>();
            services.AddScoped<IMapperContasPagar, MapperContasPagar>();
            services.AddScoped<IMapperEndereco, MapperEndereco>();
            services.AddScoped<IMapperEspecialidade, MapperEspecialidade>();
            services.AddScoped<IMapperExercicio, MapperExercicio>();
            services.AddScoped<IMapperFormaPagamento, MapperFormaPagamento>();
            services.AddScoped<IMapperMatricula, MapperMatricula>();
            services.AddScoped<IMapperModalidade, MapperModalidade>();
            services.AddScoped<IMapperProfessor, MapperProfessor>();
            services.AddScoped<IMapperSala, MapperSala>();

        }
    }
}
