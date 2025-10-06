using JadooTravel.Services.CategorySerices;
using JadooTravel.Services.DestinationServices;
using JadooTravel.Settings;
using Microsoft.Extensions.Options;
using System.Reflection;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using JadooTravel.Services.FeatureServices;
using JadooTravel.Services.TestPlanServices;
using JadooTravel.Services.TestimonialServices;
using JadooTravel.Services.RezervationServices;
using JadooTravel.Services;

var builder = WebApplication.CreateBuilder(args);

// ---------------------------
// Mevcut servisler
// ---------------------------
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IDestinationService, DestinationService>();
builder.Services.AddScoped<IFeatureService, FeatureService>();
builder.Services.AddScoped<ITripPlanService, TripPlanService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IRezervationService, RezervationService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettingsKey"));

builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});

// ---------------------------
// Localization (dil deste�i)
// ---------------------------
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services
    .AddControllersWithViews()
    .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

var app = builder.Build();

// ---------------------------
// Supported cultures (desteklenen diller)
// ---------------------------
var supportedCultures = new[]
{
    new CultureInfo("tr-TR"),
    new CultureInfo("en-US"),
    new CultureInfo("de-DE"),
    new CultureInfo("fr-FR"),
    new CultureInfo("es-ES")
};

var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("tr-TR"), // Ba�lang�� dili
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
};

// Provider s�ras�: �nce query string -> cookie -> browser header
localizationOptions.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider { QueryStringKey = "culture", UIQueryStringKey = "ui-culture" });

app.UseRequestLocalization(localizationOptions);

// ---------------------------
// Pipeline (mevcut)
// ---------------------------
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();