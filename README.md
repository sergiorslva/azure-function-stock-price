# azure-function-stock-price
This is a sample how to use Azure Function v4 to make Http requests

## Running the project
- Create an account at https://finnhub.io
- Update local.settings.json file
  ```
    "api_url": "https://finnhub.io/api/v1/",
    "api_key": "REPLACE_WITH_YOUR_API_KEY"
  ```
- Run dotnet build
- Run func start
  > Make sure you have azure-functions-core-tool. If don't run: **npm install -g azure-functions-core-tools@3 --unsafe-perm true**
 
 - Run in your browser
 http://localhost:7071/api/stock-quote/symbol/AAPL
 
 ```
 {
  "Open": 130.92,
  "High": 132.41,
  "Low": 129.64,
  "Current": 131.86,
  "PreviousClose": 132.23
}
 ```
 
  
