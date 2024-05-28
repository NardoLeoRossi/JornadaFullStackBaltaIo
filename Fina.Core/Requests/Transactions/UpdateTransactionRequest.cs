using Fina.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class UpdateTransactionRequest: Request
{
    [Required]
    public long Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public ETransactionType Type{ get; set; }


}
