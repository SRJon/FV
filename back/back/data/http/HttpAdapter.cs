using back.domain.entities;
using Microsoft.AspNetCore.Mvc;

namespace back.data.http
{
    public class HttpAdapter<T>
    {
        public int StatusCode { get; set; }
        public IResponse<T> Response { get; set; }
        public ActionResult result { get; set; }
        public HttpAdapter(int statusCode, IResponse<T> response)
        {
            StatusCode = statusCode;
            Response = response;
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
    }
}