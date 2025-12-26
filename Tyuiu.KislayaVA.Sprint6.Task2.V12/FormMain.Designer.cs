namespace Tyuiu.KislayaVA.Sprint6.Task2.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridFunc = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            buttonInfo = new Button();
            buttonDone = new Button();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridFunc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            SuspendLayout();
            // 
            // dataGridFunc
            // 
            dataGridFunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFunc.Columns.AddRange(new DataGridViewColumn[] { X, c });
            dataGridFunc.Location = new Point(454, 63);
            dataGridFunc.Name = "dataGridFunc";
            dataGridFunc.RowHeadersVisible = false;
            dataGridFunc.RowHeadersWidth = 51;
            dataGridFunc.Size = new Size(113, 375);
            dataGridFunc.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // c
            // 
            c.HeaderText = "F(X)";
            c.MinimumWidth = 6;
            c.Name = "c";
            c.Width = 50;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(227, 376);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(62, 62);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "button1";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(295, 376);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(141, 62);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "button2";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(22, 345);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 3;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(22, 394);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 4;
            // 
            // chartFunc
            // 
            chartArea1.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunc.Legends.Add(legend1);
            chartFunc.Location = new Point(592, 63);
            chartFunc.Name = "chartFunc";
            chartFunc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunc.Series.Add(series1);
            chartFunc.Size = new Size(375, 375);
            chartFunc.TabIndex = 5;
            chartFunc.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 450);
            Controls.Add(chartFunc);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(dataGridFunc);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridFunc).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridFunc;
        private Button buttonInfo;
        private Button buttonDone;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn c;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
    }
}
