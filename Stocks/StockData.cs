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
            Date = DateTime.Parse(array[0].Trim('"'));
            Open = double.Parse(array[1]);
            High = double.Parse(array[2]);
            Low = double.Parse(array[3]);
            Close = double.Parse(array[4]);
        } 

        public string Symbol { get; set; }
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public double Low { get; set; }
        public double High { get; set; }
        public double Open { get; set; }
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

        public static List<StockData> GetStockData(string symbol, DateTime startDate, DateTime endDate, BarScope scope)
        {
            const string baseUrl = "http://ichart.finance.yahoo.com/table.csv?";
            var queryText = BuildHistoricalDataRequest(symbol, startDate, DateTime.Today, scope);
            var url = string.Format("{0}{1}", baseUrl, queryText);


            var request = (HttpWebRequest) WebRequest.CreateDefault(new Uri(url));
            
            request.Timeout = 300000;
            var response = (HttpWebResponse) request.GetResponse();
            // ReSharper disable once AssignNullToNotNullAttribute
            var stream  = new StreamReader(response.GetResponseStream(), true);

            return GetStockDataFromStream(stream).OrderBy( x => x.Date).ToList();            
        }

        static string BuildHistoricalDataRequest(string symbol, DateTime startDate, DateTime endDate, BarScope scope)
        {
            var request = new StringBuilder();
            request.AppendFormat("s={0}", symbol);
            request.AppendFormat("&a={0}", startDate.Month - 1);
            request.AppendFormat("&b={0}", startDate.Day);
            request.AppendFormat("&c={0}", startDate.Year);
            request.AppendFormat("&d={0}", endDate.Month - 1);
            request.AppendFormat("&e={0}", endDate.Day);
            request.AppendFormat("&f={0}", endDate.Year);
            request.AppendFormat("&g={0}", scope); //daily

            return request.ToString();
        }
    }

    public enum BarScope
    {
        // ReSharper disable InconsistentNaming
        d = 1,
        w = 2,
        m = 3
        // ReSharper restore InconsistentNaming
    }
}
