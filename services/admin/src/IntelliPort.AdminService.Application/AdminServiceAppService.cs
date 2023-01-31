using IntelliPort.AdminService.Localization;
using Volo.Abp.Application.Services;

namespace IntelliPort.AdminService;

public abstract class AdminServiceAppService : ApplicationService
{
    protected AdminServiceAppService()
    {
        LocalizationResource = typeof(AdminServiceResource);
        ObjectMapperContext = typeof(AdminServiceApplicationModule);
    }
}