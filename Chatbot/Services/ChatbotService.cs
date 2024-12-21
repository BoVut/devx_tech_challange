using Chatbot.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.Services
{
    internal class ChatbotService(IStockService stockService) : IChatbotService
    {
        public void Run()
        {
            Console.WriteLine("Hello!");

            var data = stockService.GetExchanges();

            foreach (var exchange in data) {
                Console.WriteLine(exchange.Code);
            }
            Console.ReadLine();
        }
    }
}
