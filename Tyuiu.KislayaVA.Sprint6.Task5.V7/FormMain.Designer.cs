namespace Tyuiu.KislayaVA.Sprint6.Task5.V7
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxCondition.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(658, 22);
            button3.Name = "button3";
            button3.Size = new Size(94, 58);
            button3.TabIndex = 2;
            button3.Text = "Справка";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(558, 22);
            button2.Name = "button2";
            button2.Size = new Size(94, 58);
            button2.TabIndex = 1;
            button2.Text = "Открыть файл";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(458, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 58);
            button1.TabIndex = 0;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(208, 109);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(522, 329);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(12, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(182, 310);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(4, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 362);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(4, 3);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(448, 77);
            groupBoxCondition.TabIndex = 6;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            groupBoxCondition.Enter += groupBox2_Enter;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(24, 33);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(385, 20);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Прочитать данные из файла, вывести числа больше 5";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxCondition);
            Controls.Add(dataGridView1);
            Controls.Add(chart1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 Таск 5 Вариант 7 Кислая В. А.";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column1;
        private GroupBox groupBoxCondition;
        private Label labelCondition;
    }
}
