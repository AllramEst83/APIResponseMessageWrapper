using System;
using System.Collections.Generic;
using System.Text;

namespace APIResponseMessageWrapper.Model
{
   public class GetAllRolesResponseMessage
    {
        public List<GetAllRoles> ListOfAllRoles { get; set; }
        public int StatusCode { get; set; }
        public string Error { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
