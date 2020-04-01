using Microsoft.Extensions.DependencyInjection;
using Pilates.Adapter.Map.CadastroBaseModalidade;
using Pilates.Application.Services.Modalidade;
using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseModalidade;
using Pilates.Service.Services.CadastroBase.CadastroBaseModalidade;

namespace Pilates.WebApi.Providers
{
    public static class CadastroBaseServices
    {
        public static void AddCadastroBaseServices(this IServiceCollection services)
        {
            //Serviços de Aplicação
            services.AddScoped<IApplicationServiceModalidade, ApplicationServiceModalidade>();

            //Serviços Crud
            services.AddScoped<IServiceModalidade, ServiceModalidade>();

            //Repositórios
            services.AddScoped<IRepositoryModalidade, RepositoryModalidade>();

            //Adapters
            services.AddScoped<IMapperModalidade, MapperModalidade>();
        }
    }
}
