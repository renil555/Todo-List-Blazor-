using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkX1pGaV5EQmFJfFBmQ2ldeFRzcEU3HVdTRHRcQlxiTn5UdEFiW3pZeXA=;Mgo+DSMBPh8sVXJ0S0J+XE9AdVRAQmJPYVF2R2BJeVR0c19FZEwgOX1dQl9gSX9ScUVkW3tfcnJVRGM=;ORg4AjUWIQA/Gnt2VVhkQlFaclxJX3xIeEx0RWFab1h6cFJMY1hBNQtUQF1hSn5Sd0JjXn1acXZSRmRY;OTU0MjEzQDMyMzAyZTM0MmUzMGZuMkFvNk9tWnlhUXRsQmVhemxMRHNSV2ttZ0p3eHQwQVBIa2NoNmtCZVU9;OTU0MjE0QDMyMzAyZTM0MmUzMGxvbWQxUFJtYU9jOFpWZUZyTW55LzdCQ0FGYkllamRXeFZqTzVFbkNvR2M9;NRAiBiAaIQQuGjN/V0Z+WE9EaFtBVmFWf1VpR2NbfE52flFBal9VVAciSV9jS31Td0RkWXhcdHVXQWhUVQ==;OTU0MjE2QDMyMzAyZTM0MmUzMFpqUHh4cHMreHlTZS9vVnJtbm5JaVlLWXhBMEgybEdxemZROFN6dGJYaVE9;OTU0MjE3QDMyMzAyZTM0MmUzMFBOb2ErOTZsbVhoQ3NLdzB2RE1DM0xiTmtXclU1Q0Q0ME1aVXo4QThqZ3c9;Mgo+DSMBMAY9C3t2VVhkQlFaclxJX3xIeEx0RWFab1h6cFJMY1hBNQtUQF1hSn5Sd0JjXn1acXZdQGZY;OTU0MjE5QDMyMzAyZTM0MmUzME8vN0xxZnpFMzJ2UzhTdVoyaVJvdjdvdld5N1pWKzlXb2RUYkg2UVlURUE9;OTU0MjIwQDMyMzAyZTM0MmUzMEszRHpleVFHU0s0bHRab2pEVXpUQkgvbk1TV1lmNit4SVdkNGN5Y3FVRnM9;OTU0MjIxQDMyMzAyZTM0MmUzMFpqUHh4cHMreHlTZS9vVnJtbm5JaVlLWXhBMEgybEdxemZROFN6dGJYaVE9");
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
