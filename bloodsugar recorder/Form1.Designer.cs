namespace bloodsugar_recorder
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblEnterData = new System.Windows.Forms.Label();
            this.testDate = new System.Windows.Forms.DateTimePicker();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.chrBloodS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBResult = new System.Windows.Forms.ListBox();
            this.btnShowDict = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrBloodS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowDict);
            this.groupBox1.Controls.Add(this.listBResult);
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Controls.Add(this.lblEnterData);
            this.groupBox1.Controls.Add(this.testDate);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blood Sugar Levels";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(550, 95);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(172, 42);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Enter Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblEnterData
            // 
            this.lblEnterData.AutoSize = true;
            this.lblEnterData.Location = new System.Drawing.Point(547, 16);
            this.lblEnterData.Name = "lblEnterData";
            this.lblEnterData.Size = new System.Drawing.Size(175, 26);
            this.lblEnterData.TabIndex = 5;
            this.lblEnterData.Text = "Please enter the results of your test\r\n in milligrams per a liter (mg/l) below:";
            this.lblEnterData.Click += new System.EventHandler(this.lblEnterData_Click);
            // 
            // testDate
            // 
            this.testDate.Location = new System.Drawing.Point(9, 32);
            this.testDate.Name = "testDate";
            this.testDate.Size = new System.Drawing.Size(194, 20);
            this.testDate.TabIndex = 1;
            this.testDate.ValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(550, 59);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(172, 20);
            this.txtResult.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date of Test";
            // 
            // chrBloodS
            // 
            this.chrBloodS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.chrBloodS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrBloodS.Legends.Add(legend1);
            this.chrBloodS.Location = new System.Drawing.Point(0, 19);
            this.chrBloodS.Name = "chrBloodS";
            this.chrBloodS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Sugar Levels";
            this.chrBloodS.Series.Add(series1);
            this.chrBloodS.Size = new System.Drawing.Size(722, 198);
            this.chrBloodS.TabIndex = 2;
            this.chrBloodS.Text = "chart1";
            this.chrBloodS.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chrBloodS);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 223);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recorded Levels Over Time";
            // 
            // listBResult
            // 
            this.listBResult.FormattingEnabled = true;
            this.listBResult.Location = new System.Drawing.Point(9, 58);
            this.listBResult.Name = "listBResult";
            this.listBResult.Size = new System.Drawing.Size(194, 95);
            this.listBResult.TabIndex = 7;
            // 
            // btnShowDict
            // 
            this.btnShowDict.Location = new System.Drawing.Point(225, 32);
            this.btnShowDict.Name = "btnShowDict";
            this.btnShowDict.Size = new System.Drawing.Size(138, 47);
            this.btnShowDict.TabIndex = 8;
            this.btnShowDict.Text = "Show Previous Results";
            this.btnShowDict.UseVisualStyleBackColor = true;
            this.btnShowDict.Click += new System.EventHandler(this.btnShowDict_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrBloodS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrBloodS;
        private System.Windows.Forms.DateTimePicker testDate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblEnterData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnShowDict;
        private System.Windows.Forms.ListBox listBResult;
    }
}

