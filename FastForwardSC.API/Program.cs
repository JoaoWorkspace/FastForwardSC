using AutoMapper;
using EventMicroservice;
using FastForwardSC.API.Settings;
using ManagerAPI.Startup;
using Microsoft.Extensions.Logging;
using ProductMicroservice;
using PromotionMicroservice;
using RatingMicroservice;
using Shared.Services;
using StoreMicroservice;
using UserMicroservice;
using UserMicroservice.Repositories;

#region builder

var builder = WebApplication.CreateBuilder(args);

/*Configure from AppSettings*/
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection(DatabaseSettings.SectionKey));
builder.Services.AddLogging();

/*Configure Microservices*/
builder.Services.ConfigureMicroservices(builder);

/*Repositories*/
builder.Services.AddScoped<IUserRepository, UserRepository>();

/*Configure Services*/
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IPromotionService, PromotionService>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IStoreService, StoreService>();
builder.Services.AddScoped<IUserService, UserService>();

/*Finish configuring builder*/
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#endregion builder

#region app

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

#endregion app
