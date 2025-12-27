namespace Tyuiu.KislayaVA.Sprint6.Task7.V2
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonOKInfo_KVA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(248, 60);
            label1.TabIndex = 0;
            label1.Text = "Выполнила Кислая В. А. РППб25-1\r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(416, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 308);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonOKInfo_KVA
            // 
            buttonOKInfo_KVA.Location = new Point(684, 398);
            buttonOKInfo_KVA.Name = "buttonOKInfo_KVA";
            buttonOKInfo_KVA.Size = new Size(94, 29);
            buttonOKInfo_KVA.TabIndex = 2;
            buttonOKInfo_KVA.Text = "Окей";
            buttonOKInfo_KVA.UseVisualStyleBackColor = true;
            buttonOKInfo_KVA.Click += buttonOKInfo_KVA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOKInfo_KVA);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonOKInfo_KVA;
    }
}