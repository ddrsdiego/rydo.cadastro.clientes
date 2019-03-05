using Microsoft.Extensions.DependencyInjection;

namespace Rydo.Cadastro.Clientes.Api.Rydo.Cadastro.Clientes.IoC
{
    public static class RydoCadastroClientesContainer
    {
        public static IServiceCollection AddRydoCadastroClientesServices(this IServiceCollection services)
        {
            services.AddHandlers();
            return services;
        }
    }
}
