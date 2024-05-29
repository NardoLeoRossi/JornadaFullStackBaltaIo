using Fina.Api.Data;
using Fina.Core.Handlers;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;
using System.Transactions;

namespace Fina.Api.Handlers;

public class TransactionHandler(AppDbContext dbContext) : ITransactionHandler
{
    public Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResponse<List<Transaction>?>> GetByPeriodAsync(GetTransactionsByPeriodRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<Response<Transaction?>> GetByYdAsync(GetTransactionByIdRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest request)
    {
        throw new NotImplementedException();
    }
}
