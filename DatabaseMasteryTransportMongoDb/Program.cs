using DatabaseMasteryTransportMongoDb.Services.AboutServices;
using DatabaseMasteryTransportMongoDb.Services.BrandServices;
using DatabaseMasteryTransportMongoDb.Services.GetInTouchServices;
using DatabaseMasteryTransportMongoDb.Services.HowItWorkServices;
using DatabaseMasteryTransportMongoDb.Services.OfferServices;
using DatabaseMasteryTransportMongoDb.Services.ProjectSectionServices;
using DatabaseMasteryTransportMongoDb.Services.QuestionServices;
using DatabaseMasteryTransportMongoDb.Services.SliderServices;
using DatabaseMasteryTransportMongoDb.Services.TestimonialServices;
using DatabaseMasteryTransportMongoDb.Settings;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IOfferService, OfferService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IGetInTouchService, GetInTouchService>();
builder.Services.AddScoped<IHowItWorkService, HowItWorkService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IProjectSectionService, ProjectSectionService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettingsKey"));
builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
	return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
