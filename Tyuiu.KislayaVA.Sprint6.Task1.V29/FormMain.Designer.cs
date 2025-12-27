namespace Tyuiu.KislayaVA.Sprint6.Task1.V29
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
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            groupBoxFunc = new GroupBox();
            labelFunc = new Label();
            textBoxFunc = new TextBox();
            groupBoxData = new GroupBox();
            labelStop = new Label();
            labelStart = new Label();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            pictureBoxCondition = new PictureBox();
            groupBoxCondition.SuspendLayout();
            groupBoxFunc.SuspendLayout();
            groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(pictureBoxCondition);
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(11, 20);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(565, 306);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(7, 23);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(258, 20);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Произвести табулирование функци";
            // 
            // groupBoxFunc
            // 
            groupBoxFunc.Controls.Add(labelFunc);
            groupBoxFunc.Controls.Add(textBoxFunc);
            groupBoxFunc.Location = new Point(582, 20);
            groupBoxFunc.Name = "groupBoxFunc";
            groupBoxFunc.Size = new Size(250, 418);
            groupBoxFunc.TabIndex = 1;
            groupBoxFunc.TabStop = false;
            groupBoxFunc.Text = "Вывод данных";
            // 
            // labelFunc
            // 
            labelFunc.AutoSize = true;
            labelFunc.Location = new Point(6, 30);
            labelFunc.Name = "labelFunc";
            labelFunc.Size = new Size(75, 20);
            labelFunc.TabIndex = 1;
            labelFunc.Text = "Результат";
            // 
            // textBoxFunc
            // 
            textBoxFunc.Enabled = false;
            textBoxFunc.Location = new Point(6, 53);
            textBoxFunc.Multiline = true;
            textBoxFunc.Name = "textBoxFunc";
            textBoxFunc.Size = new Size(238, 346);
            textBoxFunc.TabIndex = 0;
            textBoxFunc.TextChanged += textBoxFunc_TextChanged;
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(labelStop);
            groupBoxData.Controls.Add(labelStart);
            groupBoxData.Controls.Add(textBoxEnd);
            groupBoxData.Controls.Add(textBoxStart);
            groupBoxData.Location = new Point(12, 332);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(299, 106);
            groupBoxData.TabIndex = 2;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(167, 37);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(91, 20);
            labelStop.TabIndex = 3;
            labelStop.Text = "Конец шага";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(6, 37);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(85, 20);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(167, 60);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 60);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(317, 350);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(74, 68);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(397, 351);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(179, 68);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.Image = (Image)resources.GetObject("pictureBoxCondition.Image");
            pictureBoxCondition.Location = new Point(20, 71);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(360, 99);
            pictureBoxCondition.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCondition.TabIndex = 1;
            pictureBoxCondition.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(groupBoxData);
            Controls.Add(groupBoxFunc);
            Controls.Add(groupBoxCondition);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 29 | Кислая В. А.";
            Load += Form1_Load;
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxFunc.ResumeLayout(false);
            groupBoxFunc.PerformLayout();
            groupBoxData.ResumeLayout(false);
            groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private Label labelCondition;
        private GroupBox groupBoxFunc;
        private Label labelFunc;
        private TextBox textBoxFunc;
        private GroupBox groupBoxData;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Button buttonInfo;
        private Button buttonDone;
        private Label labelStop;
        private Label labelStart;
        private PictureBox pictureBoxCondition;
    }
}
