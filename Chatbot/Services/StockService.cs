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
        public Stock GetExchangeStockByCode(string exchangeCode, string stockCode)
        {
            var stock = GetExchangeByCode(exchangeCode).TopStocks.Where(x => x.Code.Equals(stockCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            return stock;
        }

        public StockExchange GetExchangeByCode(string code)
        {
            return StockData.GetData().Where(x => x.Code.Equals(code, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        public StockExchange[] GetExchanges()
        {
            return StockData.GetData();
        }
    }
}
