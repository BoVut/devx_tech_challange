using Chatbot.Data;
using Chatbot.Models;
using Chatbot.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.Services
{
    internal class StockService : IStockService
    {
        public StockExchange[] GetExchanges()
        {
            return StockData.GetData();
        }
    }
}
