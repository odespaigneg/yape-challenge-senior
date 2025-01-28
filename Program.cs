using yape_challenge_senior.Adapters;
using yape_challenge_senior.Models;
using yape_challenge_senior.Ports;
using yape_challenge_senior.Services;
using yape_challenge_senior.Vendors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISmsVendor, SmsVendor>();
builder.Services.AddSingleton<IEmailVendor, EmailVendor>();
builder.Services.AddSingleton<ICallVendor, CallVendor>();
builder.Services.AddSingleton<IWhatsAppVendor, WhatsAppVendor>();
builder.Services.AddSingleton<INotifier, SmsNotifier>();
builder.Services.AddSingleton<INotifier, EmailNotifier>();
builder.Services.AddSingleton<INotifier, CallNotifier>();
builder.Services.AddSingleton<INotifier, WhatsAppNotifier>();
builder.Services.AddSingleton<NotificationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/notify", (Notification notification, NotificationService notificationService) => {
    notificationService.SendNotification(notification);
})
.WithName("NotifyService")
.WithOpenApi();

app.Run();