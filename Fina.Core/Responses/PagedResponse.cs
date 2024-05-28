namespace Fina.Core.Responses;

public class PagedResponse<T>: Response<T>
{
    public int CurrentPage { get; set; 
    }
    public int TotalPages { get; set; } = (int)Math.Ceiling(TotalCount / (double) PageSize);

    public int PageSize { get; set; } = Configuration.DefaultPageZie;

    public int TotalCount { get; set; }

    public PagedResponse(T data, int code = Configuration.DefaultStatusCode, string? message = null)
    {
        
    }
}
