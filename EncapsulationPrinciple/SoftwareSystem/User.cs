namespace EncapsulationPrinciple;

/*
 * Imagine a system where users have different roles, like “Admin,” “User,” and “Guest.”
 * Each role has different permissions, like “Read,” “Write,” and “Delete.”
 * The system must encapsulate and manage these permissions to ensure security and proper access.
 */
public class User
{
    private string name;
    private Role userRole;

    public User(string name, Role role)
    {
        this.name = name;
        this.userRole = role;
    }
    
    public string Name => this.name;

    public bool HasPermission(PermissionType permission)
    {
        return userRole.HasPermission(permission);
    }
}

public class Role
{
    private string roleName;
    private List<PermissionType> permissions = new List<PermissionType>();
    public Role(string roleName, List<PermissionType> permissions)
    {
        this.roleName = roleName;
        this.permissions = permissions;
    }

    public bool HasPermission(PermissionType permission)
    {
        return this.permissions.Contains(permission);
    }
}