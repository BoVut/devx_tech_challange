using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Chatbot.Models
{
    internal class StockExchange
    {
        [JsonPropertyName("code")]
        public required string Code;
        [JsonPropertyName("stockExchange")]
        public required string Name;
        [JsonPropertyName("topStocks")]
        public required Stock[] TopStocks;
    }
}
