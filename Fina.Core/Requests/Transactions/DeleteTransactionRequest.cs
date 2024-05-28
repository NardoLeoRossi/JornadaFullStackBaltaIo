using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class DeleteTransactionRequest: Request
{
    [Required]
    public long Id { get; set; }
}
