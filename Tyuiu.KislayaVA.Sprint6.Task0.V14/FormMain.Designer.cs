namespace Tyuiu.KislayaVA.Sprint6.Task0.V14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone_KVA = new Button();
            buttonInfo_KVA = new Button();
            textBoxEnter_KVA = new TextBox();
            textBoxDone_KVA = new TextBox();
            pictureCondition = new PictureBox();
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            groupBoxX = new GroupBox();
            labelX = new Label();
            groupBoxDone = new GroupBox();
            labelDone = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureCondition).BeginInit();
            groupBoxCondition.SuspendLayout();
            groupBoxX.SuspendLayout();
            groupBoxDone.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_KVA
            // 
            buttonDone_KVA.Location = new Point(454, 382);
            buttonDone_KVA.Name = "buttonDone_KVA";
            buttonDone_KVA.Size = new Size(133, 56);
            buttonDone_KVA.TabIndex = 0;
            buttonDone_KVA.Text = "Выполнить";
            buttonDone_KVA.UseVisualStyleBackColor = true;
            buttonDone_KVA.Click += buttonDone_KVA_Click;
            // 
            // buttonInfo_KVA
            // 
            buttonInfo_KVA.Location = new Point(384, 382);
            buttonInfo_KVA.Name = "buttonInfo_KVA";
            buttonInfo_KVA.Size = new Size(64, 56);
            buttonInfo_KVA.TabIndex = 1;
            buttonInfo_KVA.Text = "?";
            buttonInfo_KVA.UseVisualStyleBackColor = true;
            buttonInfo_KVA.Click += buttonInfo_KVA_Click;
            // 
            // textBoxEnter_KVA
            // 
            textBoxEnter_KVA.Location = new Point(6, 61);
            textBoxEnter_KVA.Name = "textBoxEnter_KVA";
            textBoxEnter_KVA.Size = new Size(125, 27);
            textBoxEnter_KVA.TabIndex = 2;
            textBoxEnter_KVA.TextChanged += textBoxEnter_KVA_TextChanged;
            // 
            // textBoxDone_KVA
            // 
            textBoxDone_KVA.Location = new Point(6, 61);
            textBoxDone_KVA.Name = "textBoxDone_KVA";
            textBoxDone_KVA.Size = new Size(125, 27);
            textBoxDone_KVA.TabIndex = 3;
            // 
            // pictureCondition
            // 
            pictureCondition.Image = (Image)resources.GetObject("pictureCondition.Image");
            pictureCondition.Location = new Point(346, 26);
            pictureCondition.Name = "pictureCondition";
            pictureCondition.Size = new Size(200, 99);
            pictureCondition.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCondition.TabIndex = 4;
            pictureCondition.TabStop = false;
            pictureCondition.Click += pictureBox1_Click;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Controls.Add(pictureCondition);
            groupBoxCondition.Location = new Point(24, 30);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(563, 249);
            groupBoxCondition.TabIndex = 5;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(24, 46);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(257, 20);
            labelCondition.TabIndex = 5;
            labelCondition.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxX
            // 
            groupBoxX.Controls.Add(labelX);
            groupBoxX.Controls.Add(textBoxEnter_KVA);
            groupBoxX.Location = new Point(28, 285);
            groupBoxX.Name = "groupBoxX";
            groupBoxX.Size = new Size(323, 94);
            groupBoxX.TabIndex = 6;
            groupBoxX.TabStop = false;
            groupBoxX.Text = "Ввод данных";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(6, 38);
            labelX.Name = "labelX";
            labelX.Size = new Size(111, 20);
            labelX.TabIndex = 3;
            labelX.Text = "Переменная Х";
            // 
            // groupBoxDone
            // 
            groupBoxDone.Controls.Add(labelDone);
            groupBoxDone.Controls.Add(textBoxDone_KVA);
            groupBoxDone.Location = new Point(370, 285);
            groupBoxDone.Name = "groupBoxDone";
            groupBoxDone.Size = new Size(217, 94);
            groupBoxDone.TabIndex = 7;
            groupBoxDone.TabStop = false;
            groupBoxDone.Text = "Вывод данных";
            // 
            // labelDone
            // 
            labelDone.AutoSize = true;
            labelDone.Location = new Point(6, 38);
            labelDone.Name = "labelDone";
            labelDone.Size = new Size(75, 20);
            labelDone.TabIndex = 4;
            labelDone.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 450);
            Controls.Add(buttonInfo_KVA);
            Controls.Add(buttonDone_KVA);
            Controls.Add(groupBoxCondition);
            Controls.Add(groupBoxDone);
            Controls.Add(groupBoxX);
            Name = "FormMain";
            Text = "Спринт 6 Таск 0 Вариант 14";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureCondition).EndInit();
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxX.ResumeLayout(false);
            groupBoxX.PerformLayout();
            groupBoxDone.ResumeLayout(false);
            groupBoxDone.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_KVA;
        private Button buttonInfo_KVA;
        private TextBox textBoxEnter_KVA;
        private TextBox textBoxDone_KVA;
        private PictureBox pictureCondition;
        private GroupBox groupBoxCondition;
        private Label labelCondition;
        private GroupBox groupBoxX;
        private Label labelX;
        private GroupBox groupBoxDone;
        private Label labelDone;
    }
}
