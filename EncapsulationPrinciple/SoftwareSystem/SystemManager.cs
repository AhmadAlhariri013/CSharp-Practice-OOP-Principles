namespace EncapsulationPrinciple;

public class SystemManager
{
    public void AccessResources(User user, PermissionType permissionType)
    {
        Console.WriteLine(user.HasPermission(permissionType)
            ? $"{user.Name} has {permissionType} permission and can access the resource."
            : $"{user.Name} does not have {permissionType} permission and cannot access the resource.");
    }
}