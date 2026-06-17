using KatalogApp.Persistence;
using KatalogApp.Application;
using KatalogApp.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var cultureInfo = new System.Globalization.CultureInfo("en-US");
System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistenceRegistration(builder.Configuration);
builder.Services.AddApplicationRegistration();
builder.Services.AddInfrastructureRegistration();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var dbContext = services.GetRequiredService<KatalogApp.Persistence.Context.KatalogAppDbContext>();
        // Eğer veritabanı yoksa otomatik oluşturur ve tüm bekleyen migration'ları uygular.
        // Hangi ortamda (Production/Development) çalışıyorsa, o ortamın appsettings.json dosyasındaki DB ismini baz alır.
        dbContext.Database.Migrate();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Veritabanı oluşturulurken veya migration uygulanırken bir hata oluştu.");
    }
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors();
app.MapControllers();

app.Run();
