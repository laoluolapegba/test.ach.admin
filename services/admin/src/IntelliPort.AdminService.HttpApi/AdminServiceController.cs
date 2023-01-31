using IntelliPort.AdminService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IntelliPort.AdminService;

public abstract class AdminServiceController : AbpControllerBase
{
    protected AdminServiceController()
    {
        LocalizationResource = typeof(AdminServiceResource);
    }
}