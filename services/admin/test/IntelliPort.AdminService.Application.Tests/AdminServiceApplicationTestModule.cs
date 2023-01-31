using Volo.Abp.Modularity;

namespace IntelliPort.AdminService;

[DependsOn(
    typeof(AdminServiceApplicationModule),
    typeof(AdminServiceDomainTestModule)
    )]
public class AdminServiceApplicationTestModule : AbpModule
{

}
