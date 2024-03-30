using BlazorChatAppWASM.Server.Hubs;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllersWithViews();
builder.Services.AddSignalR(opt =>
opt.MaximumReceiveMessageSize = 1024 * 1024 * 5
);




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

//app.UseRouting();

app.MapHub<ChatHub>("/chat");

//app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
