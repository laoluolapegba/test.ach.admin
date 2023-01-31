using Volo.Abp.Reflection;

namespace IntelliPort.AdminService.Permissions;

public class AdminServicePermissions
{
    public const string GroupName = "AdminService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AdminServicePermissions));
    }
}