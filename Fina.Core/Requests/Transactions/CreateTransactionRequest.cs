using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class CreateTransactionRequest
{
    [Required]
    public string Title{ get; set; } = string.Empty;

    [Required]
    public decimal Amount { get; set; }

    [Required]
    public long CategoryId { get; set; }



}
