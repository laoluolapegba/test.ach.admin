using IntelliPort.AdminService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IntelliPort.AdminService.Permissions;

public class AdminServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AdminServicePermissions.GroupName, L("Permission:AdminService"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AdminServiceResource>(name);
    }
}