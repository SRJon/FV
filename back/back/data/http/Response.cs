using back.domain.entities;
using Microsoft.AspNetCore.Mvc;

namespace back.data.http
{
    public class Response<O> : IResponse<O>
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public int TotalPages { get; set; }
        public int Page { get; set; }
        public O Data { get; set; }


        public Response()
        {

        }
        public Response(Response<O> data = null)
        {
            this.TotalPages = data.TotalPages;
            this.Page = data.Page;

        }
        public void setHttpAtr(Response<O> data = null)
        {
            this._copyFrom(data);
        }
        private void _copyFrom(Response<O> data)
        {
            this.TotalPages = data.TotalPages;
            this.Page = data.Page;
            this.StatusCode = data.StatusCode;
            this.Message = data.Message;
            this.Success = data.Success;
            this.Data = data.Data;
        }

        public ActionResult<IResponse<O>> GetResponse()
        {

            ActionResult res = null;
            var StatusCode = this.StatusCode;


            switch (StatusCode)
            {
                case 200:
                case 201:
                    res = new OkObjectResult(this);
                    break;

                case 400:
                    res = new BadRequestObjectResult(this);
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
                    res = new BadRequestObjectResult(this);
                    break;
            }


            return res;
        }

        public void SetConfig(int statusCode = 200, string message = "", bool success = true)
        {

            this.StatusCode = statusCode;
            this.Message = message;
            this.Success = success;

        }
    }
}