using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Configuration
   // .AddOcelot(builder.Environment)
   .AddJsonFile("ocelot.json")
   //.AddJsonFile("ocelot.swagger.json")
  //  .AddJsonFile("ocelot.aggregates.json")
  //  .AddJsonFile("ocelot3.aggregates2.json")
   .AddEnvironmentVariables();

builder.Services.AddOcelot(builder.Configuration);
builder.Services.AddSwaggerForOcelot(builder.Configuration, o =>
{
    o.GenerateDocsForAggregates = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerForOcelotUI(opt => { });
    //app.UseSwaggerUI();
//}


app.UseOcelot().Wait();
app.MapControllers();



app.Run();