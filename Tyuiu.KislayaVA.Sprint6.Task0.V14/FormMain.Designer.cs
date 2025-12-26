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
            buttonDone_KVA = new Button();
            buttonInfo_KVA = new Button();
            textBoxEnter_KVA = new TextBox();
            textBoxDone_KVA = new TextBox();
            SuspendLayout();
            // 
            // buttonDone_KVA
            // 
            buttonDone_KVA.Location = new Point(493, 382);
            buttonDone_KVA.Name = "buttonDone_KVA";
            buttonDone_KVA.Size = new Size(94, 56);
            buttonDone_KVA.TabIndex = 0;
            buttonDone_KVA.Text = "button1";
            buttonDone_KVA.UseVisualStyleBackColor = true;
            buttonDone_KVA.Click += buttonDone_KVA_Click;
            // 
            // buttonInfo_KVA
            // 
            buttonInfo_KVA.Location = new Point(384, 382);
            buttonInfo_KVA.Name = "buttonInfo_KVA";
            buttonInfo_KVA.Size = new Size(94, 56);
            buttonInfo_KVA.TabIndex = 1;
            buttonInfo_KVA.Text = "button1";
            buttonInfo_KVA.UseVisualStyleBackColor = true;
            buttonInfo_KVA.Click += buttonInfo_KVA_Click;
            // 
            // textBoxEnter_KVA
            // 
            textBoxEnter_KVA.Location = new Point(28, 301);
            textBoxEnter_KVA.Name = "textBoxEnter_KVA";
            textBoxEnter_KVA.Size = new Size(125, 27);
            textBoxEnter_KVA.TabIndex = 2;
            textBoxEnter_KVA.TextChanged += this.textBoxEnter_KVA_TextChanged;
            // 
            // textBoxDone_KVA
            // 
            textBoxDone_KVA.Location = new Point(159, 301);
            textBoxDone_KVA.Name = "textBoxDone_KVA";
            textBoxDone_KVA.Size = new Size(125, 27);
            textBoxDone_KVA.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDone_KVA);
            Controls.Add(textBoxEnter_KVA);
            Controls.Add(buttonInfo_KVA);
            Controls.Add(buttonDone_KVA);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_KVA;
        private Button buttonInfo_KVA;
        private TextBox textBoxEnter_KVA;
        private TextBox textBoxDone_KVA;
    }
}
