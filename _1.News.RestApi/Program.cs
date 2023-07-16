using _2.News.Persistance.EF;
using _2.News.Persistance.EF.Category;
using _2.News.Persistance.EF.NewsTags;
using _2.News.Persistance.EF.Tags;
using _2.NewsBlog.Persistanse.Ef;
using _3.News.Services.Categorys;
using _3.News.Services.Categorys.Contracts;
using _3.News.Services.NewsTags;
using _3.News.Services.NewsTags.Contracts;
using _3.News.Services.Tags;
using _3.News.Services.Tags.Contracts;
using _3.NewsBlog.EntityMap.Categorys;
using _3.NewsBlog.EntityMap.Citys.Contracts;
using _3.NewsBlog.EntityMap.Contracts;


using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EFDataContext>(_ =>
    _.UseSqlServer("Server=.;Database=NEWSDATABASEEEEEEEEE;Trusted_Connection=True;"));
builder.Services.AddScoped<CityRepasitory, EFCityRepasitory>();
builder.Services.AddScoped<CityService, CityAppService>();
builder.Services.AddScoped<UnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<CategoryService, CategoryAppService>();
builder.Services.AddScoped<CategoryRepasitory, EFCategoryRepasitory>();
builder.Services.AddScoped<TagRepasitory, EFTagRepasitory>();
builder.Services.AddScoped<TagService, TagAppService>();
builder.Services.AddScoped<NewsTagsRepasitory, EFNewsTagsRepasitory>();
builder.Services.AddScoped<NewsTagsService,NewTagAppService >();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
