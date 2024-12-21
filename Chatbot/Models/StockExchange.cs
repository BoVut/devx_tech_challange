using Newtonsoft.Json;

namespace Chatbot.Models
{
    internal class StockExchange
    {
        [JsonProperty("code")]
        public required string Code;
        [JsonProperty("stockExchange")]
        public required string Name;
        [JsonProperty("topStocks")]
        public required Stock[] TopStocks;
    }
}
