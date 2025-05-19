var builder = WebApplication.CreateBuilder(args);

// Thêm cách dịch vụ vào container.
builder.Services.AddControllers();
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection(); // Chuyển hướng HTTP sang HTTPS
app.UseRouting(); // Định tuyến yêu cầu đến các endpoint

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Định tuyến các controller 
});

app.Run();
