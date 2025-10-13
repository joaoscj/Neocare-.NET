var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddSingleton<Neocare.Domain.Interfaces.IStressEntryRepository, Neocare.Infrastructure.Repositories.InMemoryStressEntryRepository>();
builder.Services.AddScoped<Neocare.Application.Services.StressEntryService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
