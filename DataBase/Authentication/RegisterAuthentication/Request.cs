using System.Collections.Generic;
using System.Text;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class Request
    {
        public object Data { get; set; }
        public StringBuilder ErrorMessage;

        public Request()
        {
            ErrorMessage = new StringBuilder();
        }

    }
}