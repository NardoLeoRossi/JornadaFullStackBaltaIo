using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class DeleteTransactionRequest : Request
{
    [Required(ErrorMessage = "Transação Inválida")]
    public long Id { get; set; }
}