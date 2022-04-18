using DemoBugHotChocolate;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .UseRequest(n => async c => await n(c))
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
