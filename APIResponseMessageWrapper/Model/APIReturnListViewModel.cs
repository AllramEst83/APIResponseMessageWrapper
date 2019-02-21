using System;
using System.Collections.Generic;
using System.Text;

namespace APIResponseMessageWrapper.Model
{
   public class APIReturnListViewModel : APIResponseMessage
    {
        public List<UsersViewModel> ListOfUsers { get; set; }
    }
}
