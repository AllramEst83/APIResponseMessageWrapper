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
