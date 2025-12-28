namespace Dima.Core.Responses;

public class PagedResponse<TData> : Response<TData>
{
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
}