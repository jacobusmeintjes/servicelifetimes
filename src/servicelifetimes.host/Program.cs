using servicelifetimes.host.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IIdGenerator, IdGenerator>();


builder.Services.AddSingleton<IMySingletonService, MySingletonService>();
builder.Services.AddTransient<IMyScopedService, MyScopedService>();
builder.Services.AddTransient<IMySecondLevelService, MySecondLevelService>();
builder.Services.AddTransient<IMyTransientService, MyTransientService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
