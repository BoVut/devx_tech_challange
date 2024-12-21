using Newtonsoft.Json;

namespace Chatbot.Models
{
    public class Stock
    {
        [JsonProperty("code")]
        public required string Code { get; set; }
        [JsonProperty("stockName")]
        public required string StockName { get; set; }
        [JsonProperty("price")]
        public required decimal Price { get; set; }
    }
}
