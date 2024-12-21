using Chatbot.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.Services
{
    internal class ChatbotService : IChatbotService
    {
        public void Run()
        {
            Console.WriteLine("Hello!");

            Console.ReadLine();
        }
    }
}
