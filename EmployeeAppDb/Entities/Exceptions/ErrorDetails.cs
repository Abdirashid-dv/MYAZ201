using System.Text.Json;

namespace Entities.Exceptions;

public class ErrorDetails
{
    public int StatusCode { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime AtOccureTime { get; set; } = DateTime.Now;

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}