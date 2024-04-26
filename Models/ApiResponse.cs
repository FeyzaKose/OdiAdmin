namespace OdiAdmin.Models
{
    public class ApiResponse<T>
    {
        public int StatusCode { get;  set; }
        public bool IsSuccessful { get;  set; }

        public List<string> Errors { get; set; }
        public string Message { get; set; }
        public T Data { get;  set; }

        //static factory methods
        public static ApiResponse<T> Success(string message, T data, int statusCode)
        {
            return new ApiResponse<T> { Data = data, StatusCode = statusCode, IsSuccessful = true, Message = message };
        }

        public static ApiResponse<T> Success(string message, int statusCode)
        {
            return new ApiResponse<T> { Data = default(T), StatusCode = statusCode, IsSuccessful = true, Message = message };
        }

        public static ApiResponse<T> Fail(string message, List<string> errors, int statusCode)
        {
            return new ApiResponse<T> { Errors = errors, StatusCode = statusCode, IsSuccessful = false, Message = message };
        }

        public static ApiResponse<T> Fail(string message, string error, int statusCode)
        {
            return new ApiResponse<T> { Errors = new List<string> { error }, StatusCode = statusCode, IsSuccessful = false, Message = message };
        }
    }
}
