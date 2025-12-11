using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Repositories;
using Eksamensprojekt_1_semester.Services.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IBoatRepository, BoatRepository>(); //Singleton opretter kun en instans af BoatRepository i hele applikationens levetid.
builder.Services.AddTransient<JsonFileBoatService>(); //Transient opretter en ny instance hver gang den bliver requested.

builder.Services.AddSingleton<IMaintenanceRepository, MaintenanceRepository>();
builder.Services.AddTransient<JsonFileMaintenanceLogService>();

builder.Services.AddTransient<JsonFileMemberService>();
builder.Services.AddSingleton<IMemberRepository, MemberRepository>();
builder.Services.AddSingleton<IBookABoatRepository, BookABoatRepository>();
builder.Services.AddSingleton<IEventRepository, EventRepository>();

builder.Services.AddTransient<JsonFileBookingService>();

builder.Services.AddTransient<JsonFileIDLogService>();
builder.Services.AddSingleton<IIDLogRepository, IDLogRepository>();

var app = builder.Build();  // <-- ONLY ONE Build call

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();

app.Run();
