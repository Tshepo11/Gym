using GymMan.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace GymMan.Permissions;

public class GymManPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GymManPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GymManPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GymManResource>(name);
    }
}
