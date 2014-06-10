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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Date_Start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date_End = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Symbol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Chart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radio_Monthly = new System.Windows.Forms.RadioButton();
            this.Radio_Weekly = new System.Windows.Forms.RadioButton();
            this.Radio_Daily = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Text_Max = new System.Windows.Forms.TextBox();
            this.Text_Min = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(559, 322);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Date_Start
            // 
            this.Date_Start.Location = new System.Drawing.Point(242, 18);
            this.Date_Start.MaxDate = new System.DateTime(2014, 5, 27, 0, 0, 0, 0);
            this.Date_Start.Name = "Date_Start";
            this.Date_Start.Size = new System.Drawing.Size(200, 20);
            this.Date_Start.TabIndex = 1;
            this.Date_Start.Value = new System.DateTime(2014, 5, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 2);
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
            this.panel1.Size = new System.Drawing.Size(559, 322);
            this.panel1.TabIndex = 3;
            // 
            // Date_End
            // 
            this.Date_End.Location = new System.Drawing.Point(242, 68);
            this.Date_End.Name = "Date_End";
            this.Date_End.Size = new System.Drawing.Size(200, 20);
            this.Date_End.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date";
            // 
            // Text_Symbol
            // 
            this.Text_Symbol.Location = new System.Drawing.Point(12, 18);
            this.Text_Symbol.Name = "Text_Symbol";
            this.Text_Symbol.Size = new System.Drawing.Size(105, 20);
            this.Text_Symbol.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Symbol";
            // 
            // Button_Chart
            // 
            this.Button_Chart.Location = new System.Drawing.Point(12, 52);
            this.Button_Chart.Name = "Button_Chart";
            this.Button_Chart.Size = new System.Drawing.Size(105, 36);
            this.Button_Chart.TabIndex = 8;
            this.Button_Chart.Text = "GO!";
            this.Button_Chart.UseVisualStyleBackColor = true;
            this.Button_Chart.Click += new System.EventHandler(this.Button_Chart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radio_Monthly);
            this.groupBox1.Controls.Add(this.Radio_Weekly);
            this.groupBox1.Controls.Add(this.Radio_Daily);
            this.groupBox1.Location = new System.Drawing.Point(123, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scope";
            // 
            // Radio_Monthly
            // 
            this.Radio_Monthly.AutoSize = true;
            this.Radio_Monthly.Location = new System.Drawing.Point(6, 60);
            this.Radio_Monthly.Name = "Radio_Monthly";
            this.Radio_Monthly.Size = new System.Drawing.Size(62, 17);
            this.Radio_Monthly.TabIndex = 2;
            this.Radio_Monthly.TabStop = true;
            this.Radio_Monthly.Text = "Monthly";
            this.Radio_Monthly.UseVisualStyleBackColor = true;
            // 
            // Radio_Weekly
            // 
            this.Radio_Weekly.AutoSize = true;
            this.Radio_Weekly.Location = new System.Drawing.Point(6, 40);
            this.Radio_Weekly.Name = "Radio_Weekly";
            this.Radio_Weekly.Size = new System.Drawing.Size(61, 17);
            this.Radio_Weekly.TabIndex = 1;
            this.Radio_Weekly.TabStop = true;
            this.Radio_Weekly.Text = "Weekly";
            this.Radio_Weekly.UseVisualStyleBackColor = true;
            // 
            // Radio_Daily
            // 
            this.Radio_Daily.AutoSize = true;
            this.Radio_Daily.Location = new System.Drawing.Point(6, 20);
            this.Radio_Daily.Name = "Radio_Daily";
            this.Radio_Daily.Size = new System.Drawing.Size(48, 17);
            this.Radio_Daily.TabIndex = 0;
            this.Radio_Daily.TabStop = true;
            this.Radio_Daily.Text = "Daily";
            this.Radio_Daily.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Min Low";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max High";
            // 
            // Text_Max
            // 
            this.Text_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Max.Location = new System.Drawing.Point(465, 68);
            this.Text_Max.Name = "Text_Max";
            this.Text_Max.Size = new System.Drawing.Size(100, 20);
            this.Text_Max.TabIndex = 12;
            // 
            // Text_Min
            // 
            this.Text_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Min.Location = new System.Drawing.Point(465, 18);
            this.Text_Min.Name = "Text_Min";
            this.Text_Min.Size = new System.Drawing.Size(100, 20);
            this.Text_Min.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 428);
            this.Controls.Add(this.Text_Min);
            this.Controls.Add(this.Text_Max);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Button_Chart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text_Symbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date_End);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_Start);
            this.MinimumSize = new System.Drawing.Size(599, 467);
            this.Name = "Form1";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radio_Monthly;
        private System.Windows.Forms.RadioButton Radio_Weekly;
        private System.Windows.Forms.RadioButton Radio_Daily;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Text_Max;
        private System.Windows.Forms.TextBox Text_Min;

    }
}

