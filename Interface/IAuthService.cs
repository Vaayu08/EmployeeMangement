using EmployeeMangement.Models;

namespace EmployeeMangement.Interface
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginrequest);

        Role AddRole(Role role);
        bool AssignRoleToUser(AddUserRole obj);
    }
}
