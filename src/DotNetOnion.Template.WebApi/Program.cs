using DotNetOnion.Template.CrossCutting.Logging;

using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = SerilogExtensions.CreateBootstrapLogger(builder.Configuration);

try
{
    builder.Services.AddSerilogConfiguration(builder.Configuration);

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseSerilogRequestLoggingConfiguration();

    app.UseAuthorization();

    app.MapControllers();

    await app.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    await Log.CloseAndFlushAsync();
}
