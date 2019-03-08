using APIResponseMessageWrapper.Model;
using ResponseModels.Models;
using ResponseModels.ViewModels;
using System.Collections.Generic;

namespace APIResponseMessageWrapper
{
    public static class Wrappyfier
    {
        public static APIResponseMessage WrapResponse(int statusCode, string message)
        {

            APIResponseMessage responseMessage =
                new APIResponseMessage()
                {
                    StatusCode = statusCode,
                    Message = message
                };

            return responseMessage;
        }

        public static AddUserToRoleResponse WrapRemoveUserFromRole(
            string userId,
            string email,
            string role,
            int statusCode)
        {

            AddUserToRoleResponse responseMessage =
                new AddUserToRoleResponse()
                {
                    Role = role,
                    Email = email,
                    UserId = userId,
                    Code = "role_has_successfully_been_removed",
                    Description = "Role hase successfully been removed from user",
                    Error = "Role has successfully been removed.",
                    StatusCode = statusCode

                };

            return responseMessage;
        }

        public static GetUserRolesResponse WrapGetUserRoles(
        string userId,
        string email,
        List<string> roles,
        int statusCode)
        {

            GetUserRolesResponse responseMessage =
                new GetUserRolesResponse()
                {
                    Roles = roles,
                    Email = email,
                    UserId = userId,
                    Code = "all_user_roles",
                    Description = "All roles for the specified user",
                    Error = "no_error",
                    StatusCode = statusCode

                };

            return responseMessage;
        }

        public static SignUpResponse WrapSigupResponse(string id, string email, int statusCode)
        {

            SignUpResponse responseMessage =
                new SignUpResponse()
                {
                    Id = id,
                    Email = email,
                    StatusCode = statusCode,
                    Description = "Accont successfully created",
                    Error = "no_error",
                    Code = "account_created"

                };

            return responseMessage;
        }

        public static DeleteRoleResponse WrapDeleteRole(string roleId, string roleName, int statusCode)
        {
            DeleteRoleResponse responseMessage =
                new DeleteRoleResponse()
                {
                    RoleId = roleId,
                    RoleName = roleName,
                    StatusCode = statusCode,
                    Description = "Role successfully deleted",
                    Error = "no_error",
                    Code = "role_successfully_deleted"

                };

            return responseMessage;
        }

        public static AddRoleResponse WrapAddRoleResponse(string roleId, string roleName)
        {

            AddRoleResponse responseMessage =
                new AddRoleResponse()
                {
                    Id = roleId,
                    Role = roleName,
                    Code = "role_created",
                    StatusCode = 200,
                    Description = "Role has successfully been created.",
                    Error = "no_error"
                };

            return responseMessage;
        }

        public static AddUserToRoleResponse WrapAddRoleToUserResponse(string email, string role)
        {

            AddUserToRoleResponse responseMessage =
                new AddUserToRoleResponse()
                {
                    Email = email,
                    Role = role,
                    Code = "role_added_to_user",
                    StatusCode = 200,
                    Description = "Role has successfully been added to the user.",
                    Error = "no_error"
                };

            return responseMessage;
        }

        public static DeleteUserResponse WrapDeleteUserResponse(string id, string email)
        {

            DeleteUserResponse responseMessage =
                new DeleteUserResponse()
                {
                    Email = email,
                    Id = id,
                    Code = "user_deleted",
                    StatusCode = 200,
                    Description = "User has successfully been deleted and all realted roles has been unlinked.",
                    Error = "no_error"
                };

            return responseMessage;
        }

        public static GetAllRolesResponse WrapGetAllRolesResponse(List<GetAllRoles> listOfRoles)
        {

            GetAllRolesResponse responseMessage =
                new GetAllRolesResponse()
                {
                    ListOfAllRoles = listOfRoles,
                    Code = "list_of_all_roles",
                    StatusCode = 200,
                    Description = "List of all existing roles.",
                    Error = "no_error",
                    
                };

            return responseMessage;
        }

        public static GetAllUsersResponse WrapAPIList(int statusCode, string message, List<UsersResponse> listOfUsers)
        {
            GetAllUsersResponse listViewModel = 
                new GetAllUsersResponse()
            {
                   
                    StatusCode = 200,
                    Error = "No error",
                    Description = "List of all existning users.",
                    Code = "no_error",
                    ListOfAllUsers = listOfUsers
                };

            return listViewModel;
        }

    }
}
