using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _28_CalculatorWebServiceApp
{
    [RoutePrefix("api/calculator")]
    public class CalculatorController : ApiController
    {
        [HttpGet]
        [Route("add")]
        public HttpResponseMessage Add(int a, int b)
        {
            var result = a + b;
            return Request.CreateResponse(HttpStatusCode.OK, new { result });
        }

        [HttpGet]
        [Route("subtract")]
        public HttpResponseMessage Subtract(int a, int b)
        {
            var result = a - b;
            return Request.CreateResponse(HttpStatusCode.OK, new { result });
        }

        [HttpGet]
        [Route("multiply")]
        public HttpResponseMessage Multiply(int a, int b)
        {
            var result = a * b;
            return Request.CreateResponse(HttpStatusCode.OK, new { result });
        }

        [HttpGet]
        [Route("divide")]
        public HttpResponseMessage Divide(int a, int b)
        {
            if (b == 0)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Cannot divide by zero.");

            var result = a / b;
            return Request.CreateResponse(HttpStatusCode.OK, new { result });
        }
    }
}