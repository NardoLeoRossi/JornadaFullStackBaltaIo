using Fina.Api.Data;
using Fina.Core.Handlers;
using Fina.Core.Models;
using Fina.Core.Requests.Categories;
using Fina.Core.Responses;

namespace Fina.Api.Handlers;

public class CategoryHandler(AppDbContext dbContext) : ICategoryHandler
{
    public async Task<Response<Category?>> CreateAsync(CreateCategoryRequest request)
    {
        try
        {
            var category = new Category
            {
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description
            };

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return new Response<Category?>(category, 201, "Categoria criada com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new Response<Category?>(null, 500, "Não foi possível criar a categoria.");
            throw;
        }
    }

    public async Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoriesRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request)
    {
        var category = dbContext.Categories.FirstOrDefault(x=> x.Id == request.Id && x.UserId == request.UserId);


    }
}