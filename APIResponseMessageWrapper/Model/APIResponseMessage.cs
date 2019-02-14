using System;
using System.Collections.Generic;
using System.Text;

namespace APIResponseMessageWrapper.Model
{
    public class APIResponseMessage
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
