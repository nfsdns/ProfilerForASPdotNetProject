using MyNewProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyNewProject.Permissions;

public class MyNewProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MyNewProjectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MyNewProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyNewProjectResource>(name);
    }
}
