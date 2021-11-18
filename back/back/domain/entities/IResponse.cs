
using Microsoft.AspNetCore.Mvc;

namespace back.domain.entities
{
    public interface IResponse<T>
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public int TotalPages { get; set; }
        public int Page { get; set; }
        public T Data { get; set; }
        public ActionResult<IResponse<T>> GetResponse();
        public void SetConfig(int statusCode, string message, bool success, int totalPages, int page);
    }
}