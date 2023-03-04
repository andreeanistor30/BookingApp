using Booking;
using Booking.Services.BookingService;
using Booking.Services.CityServices;
using Booking.Services.CityTypeServices;
using Booking.Services.HotelServices;
using Booking.Services.LoginService;
using Booking.Services.RoomTypes;
using Booking.Services.UserServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDatabaseContext>(options => options.UseSqlServer("DefaultConnection"));
builder.Services.AddScoped<IHotelService,HotelService>();
builder.Services.AddScoped<ICityService,CityService>();
builder.Services.AddScoped<ICityTypeService,CityTypeService>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IRoomTypesService,RoomTypesService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddMvcCore();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
                          policy =>
                          {
                              policy.WithOrigins("http://localhost:3000")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler();
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);
app.UseRouting();
app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

