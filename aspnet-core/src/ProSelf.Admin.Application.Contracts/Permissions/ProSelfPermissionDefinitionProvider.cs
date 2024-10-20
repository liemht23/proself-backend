using ProSelf.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProSelf.Admin.Permissions;

public class ProSelfPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProSelfPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProSelfPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProSelfResource>(name);
    }
}
