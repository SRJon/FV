using back.domain.entities;
using Microsoft.AspNetCore.Mvc;

namespace back.data.http
{
    public class HttpAdapter<T>
    {
        public Response<T> Response { get; set; }
        public ActionResult result { get; set; }
        public HttpAdapter()
        {
        }
        public HttpAdapter(Response<T> r)
        {
            Response = r;
        }



        public ActionResult<Response<T>> GetResponse()
        {

            ActionResult res = null;
            var StatusCode = this.Response.StatusCode;


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

            return new HttpAdapter<T>();
        }
    }
}