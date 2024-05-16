using Repository.Implement;
using Repository.Interface;
using Services.Implement;
using Services.Interface;

namespace crudADO.Extention
{
    public static class DIContainer
    {
        public static void ConfigDI(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddTransient<IUserService, UserService>();
            service.AddTransient<IUserRepo,UserRepo>();
        }
    }
}
