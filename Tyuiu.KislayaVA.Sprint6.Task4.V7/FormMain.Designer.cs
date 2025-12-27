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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            textBox3 = new TextBox();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();
            pictureBox1 = new PictureBox();
            labelCondition = new Label();
            groupBoxCondition = new GroupBox();
            groupBoxData = new GroupBox();
            groupBoxDone = new GroupBox();
            labelStart = new Label();
            labelSave = new Label();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxData.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 49);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(177, 49);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 210);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(369, 521);
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
            buttonDone.Location = new Point(852, 35);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(106, 63);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(964, 35);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(101, 63);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(1102, 35);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 63);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(31, 35);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(344, 60);
            labelCondition.TabIndex = 8;
            labelCondition.Text = "Написать программу, которая выводит таблицу\r\nзначений функции\r\nРеализовать возможность сохранения\r\n";
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Location = new Point(22, 13);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(367, 99);
            groupBoxCondition.TabIndex = 9;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(labelSave);
            groupBoxData.Controls.Add(labelStart);
            groupBoxData.Controls.Add(textBoxStart);
            groupBoxData.Controls.Add(textBoxStop);
            groupBoxData.Location = new Point(434, 13);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(412, 82);
            groupBoxData.TabIndex = 10;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Ввод данных";
            // 
            // groupBoxDone
            // 
            groupBoxDone.Location = new Point(23, 184);
            groupBoxDone.Name = "groupBoxDone";
            groupBoxDone.Size = new Size(366, 529);
            groupBoxDone.TabIndex = 11;
            groupBoxDone.TabStop = false;
            groupBoxDone.Text = "Вывод";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(6, 26);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(85, 20);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага";
            // 
            // labelSave
            // 
            labelSave.AutoSize = true;
            labelSave.Location = new Point(177, 26);
            labelSave.Name = "labelSave";
            labelSave.Size = new Size(91, 20);
            labelSave.TabIndex = 3;
            labelSave.Text = "Конец шага";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 743);
            Controls.Add(labelCondition);
            Controls.Add(pictureBox1);
            Controls.Add(buttonInfo);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(chartFunc);
            Controls.Add(textBox3);
            Controls.Add(groupBoxCondition);
            Controls.Add(groupBoxDone);
            Controls.Add(groupBoxData);
            Name = "FormMain";
            Text = "Спринт 6 Таск 4 Вариант 7 Кислая В. А.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxData.ResumeLayout(false);
            groupBoxData.PerformLayout();
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
        private PictureBox pictureBox1;
        private Label labelCondition;
        private GroupBox groupBoxCondition;
        private GroupBox groupBoxData;
        private Label labelSave;
        private Label labelStart;
        private GroupBox groupBoxDone;
    }
}
