using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace IntelliPort.AdminService;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdminServiceHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AdminServiceConsoleApiClientModule : AbpModule
{

}
