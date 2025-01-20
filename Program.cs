using SmartSpExecutor;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISpExecutor>(new SpExecutor(builder.Configuration["ConnectionStrings:DefaultConnection"]!));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/GetUser", async (string email, ISpExecutor spExecutor) =>
{
    var dataAccess = new DataAccess(spExecutor);
    return await dataAccess.GetUserAsync(email);
})
.WithName("User")
.WithOpenApi();

app.Run();
