using Chatbot.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.Data
{
    internal static class StockData
    {
        public static StockExchange[] GetData()
        {
            var json = File.ReadAllText("../../../Data/stock_data.json");

            var data = JsonConvert.DeserializeObject<StockExchange[]>(json);

            return data;
        }
    }
}
