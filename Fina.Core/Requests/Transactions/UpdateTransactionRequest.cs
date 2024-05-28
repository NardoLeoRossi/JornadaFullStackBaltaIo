using Fina.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class UpdateTransactionRequest : Request
{
    [Required]
    public long Id { get; set; }

    [Required(ErrorMessage = "Título Inválido")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Valor Inválido")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Categoria Inválida")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "Data Inválida")]
    public DateTime? PaidOrReceivedAt { get; set; }
}