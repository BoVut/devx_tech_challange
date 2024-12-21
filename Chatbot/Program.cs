using Chatbot.Services;
using Chatbot.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddSingleton<IChatbotService, ChatbotService>();
    services.AddSingleton<IStockService, StockService>();
});

IHost host = builder.Build();

var chatBot = host.Services.GetRequiredService<IChatbotService>();

chatBot.Run();