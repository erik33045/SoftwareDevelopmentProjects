using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Stocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Date_Start.MaxDate = DateTime.Now.AddDays(-2);
            Date_End.MaxDate = DateTime.Now.AddDays(-1);            
        }

        /// <summary>
        /// This function will set the chart size to fit the current stock data
        /// </summary>
        /// <param name="stocks"></param>
        private void SetChartArea(List<StockData> stocks)
        {
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisX.Maximum = stocks.Count + 1;
            chart1.ChartAreas[0].AxisY.Minimum = stocks.Min(x => x.Low) - 1;
            chart1.ChartAreas[0].AxisY.Maximum = stocks.Max(x => x.High) + 1;            
        }

        /// <summary>
        /// This function will tun a list of stocks into a data series that can be charted
        /// </summary>
        /// <param name="stocks"></param>
        /// <returns></returns>
        private static Series GetStockDataSeries(List<StockData> stocks)
        {
            var stockData =
                new Series
                {
                    ChartType = SeriesChartType.Candlestick,
                    AxisLabel = ""
                };
            stockData.SetCustomProperty("PriceUpColor", "Green");
            stockData.SetCustomProperty("PriceDownColor", "Red");
            for (var i = 0; i < stocks.Count; i++)
            {
                stockData.Points.Add(new DataPoint(i,
                    new[] {stocks[i].High, stocks[i].Low, stocks[i].Open, stocks[i].Close}));
            }
            return stockData;
        }

        private void Button_Chart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Text_Symbol.Text))
                {
                    MessageBox.Show("Please Enter A Symbol", "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var stocks = StockData.GetStockData(Text_Symbol.Text.ToUpper(), Date_Start.Value, Date_End.Value);

                chart1.Series.Clear();
                var stockData = GetStockDataSeries(stocks);
                SetChartArea(stocks);
                chart1.Series.Add(stockData);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
