using Chatbot.Models;
using Chatbot.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.Services
{
    internal class ChatbotService(IStockService stockService) : IChatbotService
    {
        private string _input;
        private enum Menu {
            Main,
            ExchangeList,
            StockList,
            StockDetail
        }
        private Menu _currentMenu = Menu.Main;
        private string _currentExchangeCode = string.Empty;
        private string _currentStockCode = string.Empty;
        public void Run()
        {
            Console.WriteLine("Hello! Welcome to LSEG. I'm here to help you.");

            while (!string.Equals(_input, "exit", StringComparison.OrdinalIgnoreCase)) {

                
                switch (_currentMenu)
                {
                    case Menu.Main:
                        PrintExchanges();
                        break;
                    case Menu.ExchangeList:
                        _currentExchangeCode = _input?.ToLower() == "back"? _currentExchangeCode: _input.ToLower();
                        PrintTopStocks();
                        break;
                    case Menu.StockList:
                        _currentStockCode = _input?.ToLower() == "back"? _currentStockCode: _input.ToLower();
                        PrintStockDetail();
                        PrintMenu();
                        break;
                    default:
                        Console.WriteLine("N/A");
                        break;
                }

                Console.WriteLine();

                _input = Console.ReadLine()?.ToLower();

                if(_input == "back") {
                    _currentMenu--;
                } else if (_input == "main") { 
                    _currentMenu = Menu.Main;
                }
            }

            Console.WriteLine("Thank you. Have a nice day!");
        }

        private void PrintMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Go Back");
        }

        private void PrintStockDetail()
        {
            Stock stock = stockService.GetExchangeStockByCode(_currentExchangeCode, _currentStockCode);
            Console.WriteLine($"Stock Price of ${stock.StockName} is ${stock.Price}. Please select an option.");
        }

        private void PrintTopStocks()
        {
            Console.WriteLine($"Plese Select a stock");
            StockExchange exchange = stockService.GetExchangeByCode(_currentExchangeCode);
            foreach (var stock in exchange.TopStocks)
            {
                Console.WriteLine($"{stock.StockName} ({stock.Code})");
            }
        }

        private void PrintExchanges()
        {
            Console.WriteLine("Please select a Stock Exchange.");

            var data = stockService.GetExchanges();

            foreach (var exchange in data) {
                Console.WriteLine(exchange.Code);
            }
        }
    }

}
