using SecretFriend.Api;

var builder = WebApplication.CreateBuilder(args);
builder.AddServices();

var app = builder.Build();
app.Configure();
app.Run();