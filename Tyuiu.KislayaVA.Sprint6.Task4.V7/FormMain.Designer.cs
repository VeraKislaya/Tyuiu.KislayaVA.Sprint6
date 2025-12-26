namespace Tyuiu.KislayaVA.Sprint6.Task4.V7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            textBox3 = new TextBox();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            SuspendLayout();
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(434, 35);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(565, 35);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 107);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(369, 624);
            textBox3.TabIndex = 2;
            // 
            // chartFunc
            // 
            chartArea2.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunc.Legends.Add(legend2);
            chartFunc.Location = new Point(434, 107);
            chartFunc.Name = "chartFunc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunc.Series.Add(series2);
            chartFunc.Size = new Size(762, 624);
            chartFunc.TabIndex = 3;
            chartFunc.Text = "chart1";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(696, 35);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(94, 29);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "button1";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(796, 35);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "button2";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(1102, 35);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 29);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "button3";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 743);
            Controls.Add(buttonInfo);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(chartFunc);
            Controls.Add(textBox3);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private TextBox textBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private Button buttonDone;
        private Button buttonSave;
        private Button buttonInfo;
    }
}
