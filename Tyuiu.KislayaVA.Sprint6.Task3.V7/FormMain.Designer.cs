namespace Tyuiu.KislayaVA.Sprint6.Task3.V7
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
            buttonDone = new Button();
            buttonInfo = new Button();
            dataGridViewDone = new DataGridView();
            groupBoxCondition = new GroupBox();
            label1 = new Label();
            labelMatrix = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDone).BeginInit();
            groupBoxCondition.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(457, 328);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(144, 48);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(391, 327);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(60, 48);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // dataGridViewDone
            // 
            dataGridViewDone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDone.Location = new Point(396, 12);
            dataGridViewDone.Name = "dataGridViewDone";
            dataGridViewDone.RowHeadersWidth = 51;
            dataGridViewDone.Size = new Size(258, 292);
            dataGridViewDone.TabIndex = 2;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelMatrix);
            groupBoxCondition.Controls.Add(label1);
            groupBoxCondition.Location = new Point(18, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(351, 364);
            groupBoxCondition.TabIndex = 3;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(244, 80);
            label1.TabIndex = 0;
            label1.Text = "Дан массив 5 на 5 элементов\r\nВыполнить сортировку по\r\n возрастанию в 4 столбце\r\nРезультат вывести в DataGridView\r\n";
            // 
            // labelMatrix
            // 
            labelMatrix.AutoSize = true;
            labelMatrix.Location = new Point(88, 150);
            labelMatrix.Name = "labelMatrix";
            labelMatrix.Size = new Size(125, 100);
            labelMatrix.TabIndex = 1;
            labelMatrix.Text = "31 25 -18 12      9\r\n6   34   -2   2   -18\r\n-5   4    27  4    -1\r\n4   15   34  -6 -10\r\n0    8     5   14 -17\r\n";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 388);
            Controls.Add(groupBoxCondition);
            Controls.Add(dataGridViewDone);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Спринт 6 Таск 3 Вариант 7 Кислая В. А,";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDone).EndInit();
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonInfo;
        private DataGridView dataGridViewDone;
        private GroupBox groupBoxCondition;
        private Label label1;
        private Label labelMatrix;
    }
}
