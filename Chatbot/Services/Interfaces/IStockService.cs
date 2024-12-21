using Chatbot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.Services.Interfaces
{
    internal interface IStockService
    {
        public StockExchange[] GetExchanges();
    }
}
