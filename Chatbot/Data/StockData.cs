using Chatbot.Models;
using Newtonsoft.Json;

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
