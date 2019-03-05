using Microsoft.Extensions.DependencyInjection;
using MediatR;
namespace Rydo.Cadastro.Clientes.Api.Rydo.Cadastro.Clientes.IoC
{
    public static class HandlersContainer
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddMediatR();
            return services;
        }
    }
}