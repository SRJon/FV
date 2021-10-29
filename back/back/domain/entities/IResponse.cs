public interface IResponse<T>
{
    public T Data { get; set; }


    public bool Success { get; set; }
    public int StatusCode { get; set; }
    public string Message { get; set; }
}
