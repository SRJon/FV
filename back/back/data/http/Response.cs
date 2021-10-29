using back.domain.entities;
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
    }
}