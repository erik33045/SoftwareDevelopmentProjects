using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
            
            //Set the max dates
            Date_Start.MaxDate = DateTime.Now.AddDays(-2);
            Date_End.MaxDate = DateTime.Now.AddDays(-1);
            
            //By default just check the daily radio button
            Radio_Daily.Checked = true;

            //Set the min and max text boxes to read only
            Text_Min.ReadOnly = Text_Max.ReadOnly = true;
        }

        /// <summary>
        /// This function will set the chart size to fit the current stock data
        /// </summary>
        /// <param name="stocks"></param>
        private void SetChartArea(List<StockData> stocks)
        {
            //Remove the x axis labels
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            
            //Set the minimum and maximum for the x axis based on the stock data
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisX.Maximum = stocks.Count + 1;

            //Set the minimum and maximum for the y axis based on the stock data
            chart1.ChartAreas[0].AxisY.Minimum = stocks.Min(x => x.Low) - 2;
            chart1.ChartAreas[0].AxisY.Maximum = stocks.Max(x => x.High) + 2;
            
            //Set the background color
            chart1.ChartAreas[0].BackColor = Color.DimGray;
        }

        /// <summary>
        /// This function will tun a list of stocks into a data series that can be charted
        /// </summary>
        /// <param name="stocks"></param>
        /// <returns></returns>
        private static Series GetStockDataSeries(List<StockData> stocks)
        {
            //Create a new series for the stock data
            var dataSeries =
                new Series
                {
                    ChartType = SeriesChartType.Candlestick,
                    AxisLabel = "",
                    Color = Color.Gold                    
                };

            //Set the up and down colors
            dataSeries.SetCustomProperty("PriceUpColor", "Green");
            dataSeries.SetCustomProperty("PriceDownColor", "Red");
            
            //For the number of stocks, bind the stock data
            for (var i = 0; i < stocks.Count; i++)
            {
                dataSeries.Points.Add(new DataPoint(i,
                    new[] {stocks[i].High, stocks[i].Low, stocks[i].Open, stocks[i].Close}));
            }

            //Return the bound series
            return dataSeries;
        }

        /// <summary>
        /// Event that will fire when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Chart_Click(object sender, EventArgs e)
        {
            try
            {
                //Set the scope based on what is selected
                BarScope scope;
                if (Radio_Daily.Checked)
                    scope = BarScope.d;
                else if (Radio_Weekly.Checked)
                    scope = BarScope.w;
                else
                    scope = BarScope.m;



                //If They didn't put in any data, throw an error
                if (string.IsNullOrEmpty(Text_Symbol.Text))
                {
                    MessageBox.Show("Please Enter A Ticker Symbol", "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Grab the stocks
                var stocks = StockData.GetStockData(Text_Symbol.Text.ToUpper(), Date_Start.Value, Date_End.Value, scope);

                //Clear the existing series
                chart1.Series.Clear();

                //Grab the data series
                var stockDataSeries = GetStockDataSeries(stocks);

                //Set the chart area
                SetChartArea(stocks);

                //Add the series
                chart1.Series.Add(stockDataSeries);

                //Set the min low and max high
                Text_Min.Text = stocks.Min(x => x.Low).ToString(CultureInfo.InvariantCulture);
                Text_Max.Text = stocks.Max(x => x.High).ToString(CultureInfo.InvariantCulture);
            }
            catch(Exception ex)
            {
                //Generic exception handling in case something blows up
                MessageBox.Show(ex.Message, "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
