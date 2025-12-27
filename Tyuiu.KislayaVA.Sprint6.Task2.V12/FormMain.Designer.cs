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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridFunc = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            buttonInfo = new Button();
            buttonDone = new Button();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            groupBoxData = new GroupBox();
            labelStop = new Label();
            labelStart = new Label();
            groupBoxFunction = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridFunc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            groupBoxCondition.SuspendLayout();
            groupBoxData.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridFunc
            // 
            dataGridFunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFunc.Columns.AddRange(new DataGridViewColumn[] { X, c });
            dataGridFunc.Location = new Point(567, 63);
            dataGridFunc.Name = "dataGridFunc";
            dataGridFunc.RowHeadersVisible = false;
            dataGridFunc.RowHeadersWidth = 51;
            dataGridFunc.Size = new Size(147, 375);
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
            buttonInfo.Location = new Point(352, 376);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(62, 62);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(420, 376);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(141, 62);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 66);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 3;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(203, 66);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 4;
            // 
            // chartFunc
            // 
            chartArea2.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartFunc.Legends.Add(legend2);
            chartFunc.Location = new Point(720, 63);
            chartFunc.Name = "chartFunc";
            chartFunc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunc.Series.Add(series2);
            chartFunc.Size = new Size(375, 375);
            chartFunc.TabIndex = 5;
            chartFunc.Text = "chart1";
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(549, 327);
            groupBoxCondition.TabIndex = 6;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(26, 37);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(450, 40);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Протабулировать функцию на заданном диапазоне. \r\nРезультат вывести в DataGridVIew и построить график функции";
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(labelStop);
            groupBoxData.Controls.Add(labelStart);
            groupBoxData.Controls.Add(textBoxStop);
            groupBoxData.Controls.Add(textBoxStart);
            groupBoxData.Location = new Point(12, 345);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(334, 102);
            groupBoxData.TabIndex = 7;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(203, 43);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(91, 20);
            labelStop.TabIndex = 6;
            labelStop.Text = "Конец шага";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(6, 43);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(85, 20);
            labelStart.TabIndex = 5;
            labelStart.Text = "Старт шага";
            // 
            // groupBoxFunction
            // 
            groupBoxFunction.Location = new Point(567, 12);
            groupBoxFunction.Name = "groupBoxFunction";
            groupBoxFunction.Size = new Size(537, 435);
            groupBoxFunction.TabIndex = 8;
            groupBoxFunction.TabStop = false;
            groupBoxFunction.Text = "Вывод данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 450);
            Controls.Add(groupBoxCondition);
            Controls.Add(chartFunc);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(dataGridFunc);
            Controls.Add(groupBoxData);
            Controls.Add(groupBoxFunction);
            Name = "FormMain";
            Text = "Спринт 6 Таск 2 Вариант 12 Кислая В. А.";
            ((System.ComponentModel.ISupportInitialize)dataGridFunc).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxData.ResumeLayout(false);
            groupBoxData.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBoxCondition;
        private GroupBox groupBoxData;
        private GroupBox groupBoxFunction;
        private Label labelCondition;
        private Label labelStop;
        private Label labelStart;
    }
}
