public static class MiddlewareExtensions
{
    public static void ConfigureMiddleware(this WebApplication app)
    {
        app.UseDefaultFiles();
        app.UseStaticFiles();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.UseAuthentication();
        app.MapControllers();
        app.MapFallbackToFile("/index.html");
    }
}
