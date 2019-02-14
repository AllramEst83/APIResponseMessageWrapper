using APIResponseMessageWrapper.Model;
using System;

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

    }
}
