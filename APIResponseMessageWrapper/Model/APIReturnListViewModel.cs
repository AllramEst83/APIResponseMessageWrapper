using ResponseModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIResponseMessageWrapper.Model
{
   public class APIReturnListViewModel : APIResponseMessage
    {
        public List<UsersResponse> ListOfUsers { get; set; }
    }
}
