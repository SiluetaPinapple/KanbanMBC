using KanbanMBC.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KanbanMBC.Data;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<KanbanMBCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KanbanMBCContext") ?? throw new InvalidOperationException("Connection string 'KanbanMBCContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSignalR();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
app.MapHub<KanbanMBC.Hubs.PullRequestHub>("/pullRequestHub");

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
