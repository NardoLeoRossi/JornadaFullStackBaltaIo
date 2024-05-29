using Fina.Api.Data;
using Fina.Api.Handlers;
using Fina.Core.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

const string connectionString = @"Data Source =DESKTOP-M06C0GR; Initial Catalog=Fina; Integrated Security=True; Connect Timeout=30; Encrypt=False; User Id= sa; Password= 43leo25ale36";

builder.Services.AddDbContext<AppDbContext>(
                                    x => x.UseSqlServer(connectionString));

builder.Services.AddTransient<ICategoryHandler, CategoryHandler>();
builder.Services.AddTransient<ITransactionHandler, TransactionHandler>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
