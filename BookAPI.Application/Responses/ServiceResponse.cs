using System;

namespace BookAPI.Application.Responses;

public class ServiceResponse<T> 
{
    public T? Data { get; set; }
    public string Message { get; set; } = string.Empty;
    public bool Status { get; set; }
    
    public ServiceResponse(T? data, string message, bool status)
    {
        Data = data;
        Message = message;
        Status = status;
    }
}
