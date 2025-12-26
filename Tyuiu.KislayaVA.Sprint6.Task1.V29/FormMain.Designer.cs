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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            textBoxFunc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxFunc);
            groupBox2.Location = new Point(506, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 418);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBoxEnd);
            groupBox3.Controls.Add(textBoxStart);
            groupBox3.Location = new Point(12, 332);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(196, 106);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(214, 351);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(74, 68);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "button1";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += this.buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(305, 351);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(179, 68);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "button2";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += this.buttonDone_Click;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 26);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(6, 59);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 1;
            // 
            // textBoxFunc
            // 
            textBoxFunc.Enabled = false;
            textBoxFunc.Location = new Point(6, 53);
            textBoxFunc.Multiline = true;
            textBoxFunc.Name = "textBoxFunc";
            textBoxFunc.Size = new Size(238, 346);
            textBoxFunc.TabIndex = 0;
            textBoxFunc.TextChanged += this.textBoxFunc_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 23);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 29);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 62);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBoxFunc;
        private GroupBox groupBox3;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Button buttonInfo;
        private Button buttonDone;
        private Label label4;
        private Label label3;
    }
}
