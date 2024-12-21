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
            StockList
        }

        private bool _success = false;
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
                        PrintTopStocks();
                        break;
                    case Menu.StockList:
                        PrintStockDetail();
                        PrintMenu();
                        break;
                }

                Console.WriteLine();

                _input = Console.ReadLine()?.ToLower();


                if(_input == "back")  {
                    if ((int)_currentMenu > (int)Menu.Main) {
                        _currentMenu--;
                    }
                } else if (_input == "main") { 
                    _currentMenu = Menu.Main;
                } else if (_success) {
                    if ((int)_currentMenu < (int)Menu.StockList){
                        _currentMenu++;
                    }
                }
            }

            Console.WriteLine("Thank you. Have a nice day!");
        }

        private void PrintMenu()
        {
            Console.WriteLine("[Main] Menu");
            Console.WriteLine("Go [Back]");
            Console.WriteLine("[Exit] Chat");
        }

        private void PrintStockDetail()
        {
            if(!string.IsNullOrWhiteSpace(_input) && _input != "back")
            {
                _currentStockCode = _input;
            }
            Stock stock = stockService.GetExchangeStockByCode(_currentExchangeCode, _currentStockCode);
            if(stock != null) {
                Console.WriteLine($"Stock Price of ${stock.StockName} is ${stock.Price}. Please select an option.");
                _success = true;
            } else
            {
                Console.WriteLine($"Stock code '{_currentStockCode}' under Exchange code '{_currentExchangeCode}' not found. Please try again.");
                _success = false;
            }
        }

        private void PrintTopStocks()
        {
            if(!string.IsNullOrWhiteSpace(_input) && _input != "back")
            {
                _currentExchangeCode = _input;
            }
            Console.WriteLine($"Plese Select a stock code to veiew price detail");
            StockExchange exchange = stockService.GetExchangeByCode(_currentExchangeCode);
            if(exchange != null) {
                foreach (var stock in exchange.TopStocks)
                {
                    Console.WriteLine($"{stock.StockName} ({stock.Code})");
                }
                _success = true;
            }
            else
            {
                Console.WriteLine($"Exchange code '{_currentExchangeCode}' Not found. Please try again.");
                _success = false;
            }
        }

        private void PrintExchanges()
        {
            Console.WriteLine("Please select a Stock Exchange by code.");

            var data = stockService.GetExchanges();

            foreach (var exchange in data) {
                Console.WriteLine($"{exchange.Name} ({exchange.Code})");
            }

            _success = true;
        }
    }

}
