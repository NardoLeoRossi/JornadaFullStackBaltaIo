using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class GetTransactionByIdRequest: Request
{
    [Required]
    public long Id { get; set; }
}
