using ProductService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProductService.Permissions;

public class ProductServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProductServicePermissions.GroupName, L("Permission:ProductService"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProductServiceResource>(name);
    }
}
