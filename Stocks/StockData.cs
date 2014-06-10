using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Stocks
{
    class StockData
    {
        /// <summary>
        /// Constructor which creates a stock data object from an array of strings
        /// </summary>
        /// <param name="array"></param>
        public StockData(string[] array)
        {
            //Since we know the format of the csv will remain constant, just pluck the values out of the string array and turn
            //the strings into relevant field values
            Date = DateTime.Parse(array[0].Trim('"'));
            Open = double.Parse(array[1]);
            High = double.Parse(array[2]);
            Low = double.Parse(array[3]);
            Close = double.Parse(array[4]);
        } 

        /// <summary>
        /// Ticker Symbol
        /// </summary>
        public string Symbol { get; set; }
        
        /// <summary>
        /// Name of the company
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// What the date of the stock prices are
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// What the low price for the date was
        /// </summary>
        public double Low { get; set; }
        
        /// <summary>
        /// What the high price for the date was
        /// </summary>
        public double High { get; set; }
        
        /// <summary>
        /// What the open price was
        /// </summary>
        public double Open { get; set; }
        
        /// <summary>
        /// What the close price was
        /// </summary>
        public double Close { get; set; }

        /// <summary>
        /// Function which will take in a reader stream and return all stock data found
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        private static IEnumerable<StockData> GetStockDataFromStream(StreamReader stream)
        {
            var stockData = new List<StockData>();

            //skip header row
            stream.ReadLine();

            string csvLine;
            //While there is data to pull, add new stock data to the list
            while ((csvLine = stream.ReadLine()) != null)
                stockData.Add(new StockData(csvLine.Split(new[] { ',' })));

            return stockData;
        }

        /// <summary>
        /// Public method which will return a list of stock data
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="scope"></param>
        /// <returns></returns>
        public static List<StockData> GetStockData(string symbol, DateTime startDate, DateTime endDate, BarScope scope)
        {
            try
            {
                //Here we are building the url and query string
                const string baseUrl = "http://ichart.finance.yahoo.com/table.csv?";
                var queryText = BuildQueryString(symbol, startDate, DateTime.Today, scope);
                var url = string.Format("{0}{1}", baseUrl, queryText);

                //Create a web request with the above url
                var request = (HttpWebRequest) WebRequest.CreateDefault(new Uri(url));

                //Request a response             
                var response = (HttpWebResponse) request.GetResponse();

                // ReSharper disable once AssignNullToNotNullAttribute
                //Get the stream representation of the response
                var stream = new StreamReader(response.GetResponseStream(), true);

                //Take the stream and turn it into stock data, sort it by date, and return the list
                return GetStockDataFromStream(stream).OrderBy(x => x.Date).ToList();
            }
            catch (WebException ex)
            {
                //If the error is a 404, we should throw a more friendly message
                if (ex.Message.Contains("404"))
                    throw new Exception(string.Format("Stock data with symbol \"{0}\" was not found", symbol));
                
                //Otherwise, just rethrow
                throw;
            }
        }

        /// <summary>
        /// This function takes in the symbol, startDate, endDate, and the scope and turns that into a query string with all proper parameters set
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="scope"></param>
        /// <returns></returns>
        static string BuildQueryString(string symbol, DateTime startDate, DateTime endDate, BarScope scope)
        {
            //Make a string builder, append all the relevant fields, and then return the query strin
            var queryString = new StringBuilder();
            queryString.AppendFormat("s={0}", symbol);
            queryString.AppendFormat("&a={0}", startDate.Month - 1);
            queryString.AppendFormat("&b={0}", startDate.Day);
            queryString.AppendFormat("&c={0}", startDate.Year);
            queryString.AppendFormat("&d={0}", endDate.Month - 1);
            queryString.AppendFormat("&e={0}", endDate.Day);
            queryString.AppendFormat("&f={0}", endDate.Year);
            queryString.AppendFormat("&g={0}", scope);

            return queryString.ToString();
        }
    }

    /// <summary>
    /// This scope will determine what each bar means, d for day, w for week, m for month
    /// </summary>
    public enum BarScope
    {        
        d = 1,
        w = 2,
        m = 3        
    }
}
