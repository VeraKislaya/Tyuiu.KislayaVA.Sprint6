namespace Tyuiu.KislayaVA.Sprint6.Task6.V18
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
            buttonOpen = new Button();
            buttonDone = new Button();
            buttonInfo = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Image = (Image)resources.GetObject("buttonOpen.Image");
            buttonOpen.Location = new Point(12, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(97, 72);
            buttonOpen.TabIndex = 0;
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(115, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(97, 72);
            buttonDone.TabIndex = 1;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonSave_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Image = (Image)resources.GetObject("buttonInfo.Image");
            buttonInfo.Location = new Point(691, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(97, 72);
            buttonInfo.TabIndex = 2;
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(253, 20);
            label1.TabIndex = 3;
            label1.Text = "Дан файл, загруить его и изменить";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 63);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(15, 173);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ReadOnly = true;
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(371, 265);
            textBoxInput.TabIndex = 5;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(417, 173);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(371, 265);
            textBoxOutput.TabIndex = 6;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            openFileDialogTask.FileOk += openFileDialog1_FileOk;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxInput);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpen);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 Таск 6 Вариант 18 Кислая В. А.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpen;
        private Button buttonDone;
        private Button buttonInfo;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private OpenFileDialog openFileDialogTask;
    }
}
