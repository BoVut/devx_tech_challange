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
        public Stock GetExchangeStockByCode(string exchangeCode, string stockCode);
        public StockExchange[] GetExchanges();
        public StockExchange GetExchangeByCode(string code);
    }
}
