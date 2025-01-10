var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => { endpoints.MapGet("/", async (context) =>
{
    await context.Response.WriteAsync("Trang chủ");
})})

app.MapGet("/", () => "Hello World!");

app.Run();
