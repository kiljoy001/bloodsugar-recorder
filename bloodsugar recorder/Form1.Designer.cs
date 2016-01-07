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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowDict = new System.Windows.Forms.Button();
            this.listBResult = new System.Windows.Forms.ListBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblEnterData = new System.Windows.Forms.Label();
            this.testDate = new System.Windows.Forms.DateTimePicker();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.chrBloodS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpBTestResults = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrBloodS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpBTestResults.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Controls.Add(this.lblEnterData);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blood Sugar Levels";
            // 
            // btnShowDict
            // 
            this.btnShowDict.Location = new System.Drawing.Point(6, 151);
            this.btnShowDict.Name = "btnShowDict";
            this.btnShowDict.Size = new System.Drawing.Size(188, 35);
            this.btnShowDict.TabIndex = 8;
            this.btnShowDict.Text = "Show All Previous Results";
            this.btnShowDict.UseVisualStyleBackColor = true;
            this.btnShowDict.Click += new System.EventHandler(this.btnShowDict_Click);
            // 
            // listBResult
            // 
            this.listBResult.FormattingEnabled = true;
            this.listBResult.Location = new System.Drawing.Point(6, 63);
            this.listBResult.Name = "listBResult";
            this.listBResult.Size = new System.Drawing.Size(188, 82);
            this.listBResult.TabIndex = 7;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(9, 71);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(191, 42);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Enter Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblEnterData
            // 
            this.lblEnterData.AutoSize = true;
            this.lblEnterData.Location = new System.Drawing.Point(6, 16);
            this.lblEnterData.Name = "lblEnterData";
            this.lblEnterData.Size = new System.Drawing.Size(175, 26);
            this.lblEnterData.TabIndex = 5;
            this.lblEnterData.Text = "Please enter the results of your test\r\n in milligrams per a liter (mg/l) below:";
            this.lblEnterData.Click += new System.EventHandler(this.lblEnterData_Click);
            // 
            // testDate
            // 
            this.testDate.Location = new System.Drawing.Point(6, 32);
            this.testDate.Name = "testDate";
            this.testDate.Size = new System.Drawing.Size(188, 20);
            this.testDate.TabIndex = 1;
            this.testDate.ValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(9, 45);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(191, 20);
            this.txtResult.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Select A Date";
            // 
            // chrBloodS
            // 
            this.chrBloodS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.chrBloodS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrBloodS.Legends.Add(legend1);
            this.chrBloodS.Location = new System.Drawing.Point(6, 19);
            this.chrBloodS.Name = "chrBloodS";
            this.chrBloodS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Sugar Levels";
            this.chrBloodS.Series.Add(series1);
            this.chrBloodS.Size = new System.Drawing.Size(596, 311);
            this.chrBloodS.TabIndex = 2;
            this.chrBloodS.Text = "chart1";
            this.chrBloodS.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.chrBloodS);
            this.groupBox2.Location = new System.Drawing.Point(237, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 336);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recorded Levels Over Time";
            // 
            // grpBTestResults
            // 
            this.grpBTestResults.BackColor = System.Drawing.SystemColors.Menu;
            this.grpBTestResults.Controls.Add(this.testDate);
            this.grpBTestResults.Controls.Add(this.btnShowDict);
            this.grpBTestResults.Controls.Add(this.listBResult);
            this.grpBTestResults.Controls.Add(this.lblDate);
            this.grpBTestResults.Location = new System.Drawing.Point(12, 176);
            this.grpBTestResults.Name = "grpBTestResults";
            this.grpBTestResults.Size = new System.Drawing.Size(210, 192);
            this.grpBTestResults.TabIndex = 9;
            this.grpBTestResults.TabStop = false;
            this.grpBTestResults.Text = "Past Test Results";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(469, 71);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 42);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh Chart";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 374);
            this.Controls.Add(this.grpBTestResults);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Blood Sugar Recorder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrBloodS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpBTestResults.ResumeLayout(false);
            this.grpBTestResults.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox grpBTestResults;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

