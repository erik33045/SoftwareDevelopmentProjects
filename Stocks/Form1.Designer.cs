namespace Stocks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Date_Start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date_End = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Symbol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Chart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(331, 322);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Date_Start
            // 
            this.Date_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_Start.Location = new System.Drawing.Point(143, 18);
            this.Date_Start.MaxDate = new System.DateTime(2014, 5, 27, 0, 0, 0, 0);
            this.Date_Start.Name = "Date_Start";
            this.Date_Start.Size = new System.Drawing.Size(200, 20);
            this.Date_Start.TabIndex = 1;
            this.Date_Start.Value = new System.DateTime(2014, 5, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 322);
            this.panel1.TabIndex = 3;
            // 
            // Date_End
            // 
            this.Date_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_End.Location = new System.Drawing.Point(143, 68);
            this.Date_End.Name = "Date_End";
            this.Date_End.Size = new System.Drawing.Size(200, 20);
            this.Date_End.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date";
            // 
            // Text_Symbol
            // 
            this.Text_Symbol.Location = new System.Drawing.Point(30, 18);
            this.Text_Symbol.Name = "Text_Symbol";
            this.Text_Symbol.Size = new System.Drawing.Size(105, 20);
            this.Text_Symbol.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Symbol";
            // 
            // Button_Chart
            // 
            this.Button_Chart.Location = new System.Drawing.Point(30, 52);
            this.Button_Chart.Name = "Button_Chart";
            this.Button_Chart.Size = new System.Drawing.Size(105, 36);
            this.Button_Chart.TabIndex = 8;
            this.Button_Chart.Text = "Chart";
            this.Button_Chart.UseVisualStyleBackColor = true;
            this.Button_Chart.Click += new System.EventHandler(this.Button_Chart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 428);
            this.Controls.Add(this.Button_Chart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text_Symbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date_End);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_Start);
            this.MinimumSize = new System.Drawing.Size(371, 467);
            this.Name = "Form1";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker Date_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Date_End;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_Symbol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Chart;

    }
}

