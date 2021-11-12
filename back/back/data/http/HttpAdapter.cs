using back.domain.entities;
using Microsoft.AspNetCore.Mvc;

namespace back.data.http
{
    public class HttpAdapter<T>
    {
        public int StatusCode { get; set; }
        public T Response { get; set; }
        public ActionResult result { get; set; }
        public HttpAdapter(int statusCode)
        {
            StatusCode = statusCode;
        }
        public HttpAdapter(int statusCode, T r)
        {
            StatusCode = statusCode;
            Response = r;
        }



        public ActionResult<T> GetResponse()
        {

            ActionResult res = null;



            switch (StatusCode)
            {
                case 200:
                case 201:
                    res = new OkObjectResult(Response);
                    break;

                case 400:
                    res = new BadRequestObjectResult(Response);
                    break;
                case 401:
                    res = new UnauthorizedResult();
                    break;
                case 403:
                    res = new ForbidResult();
                    break;
                case 404:
                    res = new NotFoundResult();
                    break;

                default:
                    res = new BadRequestObjectResult(Response);
                    break;
            }


            return res;
        }

        public static HttpAdapter<T> getInstance()
        {

            return new HttpAdapter<T>(0);
        }
    }
}