using Microsoft.Extensions.DependencyInjection;
using QM.BussinessLogic.Concrete;
using QM.BussinessLogic.Concrete.Users;
using QM.BussinessLogic.Interface;

using QM.BussinessLogic.Interface.Users;

namespace QM.BussinessLogic.DIContainer
{
    public static class CustomExtensionsBll
    {
        public static void AddContainerWithDependenciesBll(this IServiceCollection services)
        {
            services.AddScoped<IAppRoleService, AppRoleManager>()
                    .AddScoped<IAppUserService, AppUserManager>()
                    .AddScoped<IFileService, FileManager>();                   

            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
        }
    }
}
