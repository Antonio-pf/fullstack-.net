namespace Fina.Core.Requests.Transactions;

public class GetTransactionbyPeriodRequest : PagedRequest
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}