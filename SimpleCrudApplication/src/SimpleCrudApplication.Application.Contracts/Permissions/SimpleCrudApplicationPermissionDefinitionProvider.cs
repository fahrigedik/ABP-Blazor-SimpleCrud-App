using SimpleCrudApplication.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace SimpleCrudApplication.Permissions;

public class SimpleCrudApplicationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SimpleCrudApplicationPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(SimpleCrudApplicationPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SimpleCrudApplicationResource>(name);
    }
}
