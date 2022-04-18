using Volo.Abp.Reflection;

namespace ProductService.Permissions;

public class ProductServicePermissions
{
    public const string GroupName = "ProductService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProductServicePermissions));
    }
}
