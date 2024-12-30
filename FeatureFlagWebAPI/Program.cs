using C3i.GerenciadorFeatureFlags;

var builder = WebApplication.CreateBuilder(args);

// Registrando o Gerenciador de Feature Flags como serviço
builder.Services.AddSingleton<AppSettingsFeatureFlagProvider>();

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();