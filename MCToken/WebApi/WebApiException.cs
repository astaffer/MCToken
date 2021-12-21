using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MCToken.WebApi
{
    public class WebApiException : ApplicationException
    {
        public HttpStatusCode StatusCode { get; private set; }

        public WebApiException(string message, HttpStatusCode statusCode)
            : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
