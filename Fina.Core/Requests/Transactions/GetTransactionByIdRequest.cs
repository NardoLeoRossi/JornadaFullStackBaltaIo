﻿using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class GetTransactionByIdRequest : Request
{
    [Required(ErrorMessage = "Id Obrigatório")]
    public long Id { get; set; }
}
