using Microsoft.Extensions.Primitives;

var featuresList = new StringValues(
    "accelerometer 'none';" +
    "autoplay 'none';" +
    "camera 'none';" +
    "document-domain 'none';" +
    "encrypted-media 'none';" +
    "fullscreen 'self';" +
    "geolocation 'none';" +
    "gyroscope 'none';" +
    "magnetometer 'none';" +
    "microphone 'none';" +
    "midi 'none';" +
    "payment 'none';" +
    "picture-in-picture 'none';" +
    "publickey-credentials-get 'none';" +
    "sync-xhr 'none';" +
    "usb 'none';" +
    "xr-spatial-tracking 'none';");

var permissionsList = new StringValues(
    "accelerometer=();" +
    "autoplay=();" +
    "camera=();" +
    "document-domain=();" +
    "encrypted-media=();" +
    "fullscreen=(self);" +
    "geolocation=();" +
    "gyroscope=();" +
    "magnetometer=();" +
    "microphone=();" +
    "midi=();" +
    "payment=();" +
    "picture-in-picture=();" +
    "publickey-credentials-get=();" +
    "speaker=(self);" +
    "sync-xhr=();" +
    "usb=();" +
    "xr-spatial-tracking=();");

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts(options =>
    {
        options.MaxAge(365);
        options.IncludeSubdomains();
        options.Preload();
    });
}

app.UseXContentTypeOptions()
    .UseReferrerPolicy(opts => opts.NoReferrer())
    .UseXXssProtection(opts => opts.EnabledWithBlockMode())
    .UseXfo(xfo => xfo.Deny())
    .UseCsp(options => options
        .DefaultSources(s => s.Self())
        .StyleSources(s => s.Self().UnsafeInline())
        .ScriptSources(s => s.Self().UnsafeInline())
        .ObjectSources(s => s.None()))
    .Use(async (context, next) =>
    {
        context.Response.Headers.Append("Expect-CT", "max-age=0, enforce");
        context.Response.Headers.Append("Feature-Policy", featuresList);
        context.Response.Headers.Append("Permissions-Policy", permissionsList);
        await next.Invoke();
    });

app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapGet("/api/config", (IConfiguration configuration) =>
    Results.Ok(new { email = configuration["ContactSettings:Email"] ?? string.Empty }));

app.MapFallbackToFile("index.html");

await app.RunAsync();
