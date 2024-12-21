using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Chatbot.Models
{
    public class Stock
    {
        [JsonPropertyName("code")]
        public required string Code { get; set; }
        [JsonPropertyName("stockName")]
        public required string StockName { get; set; }
        [JsonPropertyName("price")]
        public required decimal Price { get; set; }
    }
}
