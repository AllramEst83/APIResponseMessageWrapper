using APIResponseMessageWrapper.Model;
using System;
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

        public static RemoveUserfromRoleResponseMessage WrapRemoveUserFromRole(
            string userId, 
            string email,
            string role,
            int statusCode)
        {

            RemoveUserfromRoleResponseMessage responseMessage =
                new RemoveUserfromRoleResponseMessage()
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

        public static GetUserRolesResponseMessage WrapGetUserRoles(
        string userId,
        string email,
        List<string> roles,
        int statusCode)
        {

            GetUserRolesResponseMessage responseMessage =
                new GetUserRolesResponseMessage()
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

        public static AccountsSigupResponseMessgae WrapSigupResponse(string id, string email, int statusCode)
        {

            AccountsSigupResponseMessgae responseMessage =
                new AccountsSigupResponseMessgae()
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

        public static DeleteRoleResponseMessage WrapDeleteRole(string roleId, string roleName, int statusCode)
        {

            DeleteRoleResponseMessage responseMessage =
                new DeleteRoleResponseMessage()
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

        public static AddRoleResponseMessage WrapAddRoleResponse(string role)
        {

            AddRoleResponseMessage responseMessage =
                new AddRoleResponseMessage()
                {
                   Role = role,
                   Code = "role_created",
                   StatusCode = 200,
                   Description = "Role has successfully been created.",
                   Error = "no_error"
                };

            return responseMessage;
        }

        public static GatewayAddRoleResponse WrapAddRoleToUserResponse(string email,string role)
        {

            GatewayAddRoleResponse responseMessage =
                new GatewayAddRoleResponse()
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

        public static APIReturnListViewModel WrapAPIList(int statusCode, string message, List<UsersViewModel> listOfUsers)
        {
            APIReturnListViewModel listViewModel = new APIReturnListViewModel()
            {
                StatusCode = statusCode,
                Message = message,
                ListOfUsers = listOfUsers
            };

            return listViewModel;
        }

    }
}
