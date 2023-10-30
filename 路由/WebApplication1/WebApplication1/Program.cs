using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
//配置



var app = builder.Build();
app.MapControllers();
//应用


app.Run();


