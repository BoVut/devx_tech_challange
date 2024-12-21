# devx_tech_challange

LSEG Technical Challenge

## About

A Console application chatbot for querying StockExchange top stock prices.

### Build With

- .Net 8 C# Console Application

### Setting Up and Run the App

* Using Visual Studio

  * Ensure Visual Studio supports .Net 8. If not, update Visual Studio via Visual Studio Installer on your machine
  * Open solution on Visual Studio and Press `Ctrl + F5` to run the program
* Using dotnet CLI

  * From your terminal, navigate to the project folder and execute command: `dotnet run`

## Challange Note

### Time Spent

**Creat GitHub project & coding: ~3 hours**

* 01:00 project structure setup
* 00:30 setting up data model mapping and data service (lost some times configuring JSON mapping issue)
* 00:30 writing the Chatbot logic
* 00:30+ fixing the menu navigation issues (I ran out of time mainly for this part)

**Learn .Net Core structure & syntax and planning: 1 day**

I would not be able to setup the project without taking at least half a day studying all of these first since my work the past 2 years has been mostly with cloud infra stuffs (e.g. terraform for Azure resources, GitLab pipeline, etc.) and almost no coding at all.

Just want to be up front about my actual time spent on this challenge.

### Possible Improvements

* Unit tests (I planned to create another project for the services unit tests, but ran out of time)
* Introduce a Stock API service for data retrieval (and re-map the service using dependency injection)
* Improve user input handling to accept partially match values for better UX
