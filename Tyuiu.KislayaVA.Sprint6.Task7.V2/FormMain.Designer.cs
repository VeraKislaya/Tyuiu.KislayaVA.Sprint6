namespace Tyuiu.KislayaVA.Sprint6.Task7.V2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpen_KVA = new Button();
            buttonStart_KVA = new Button();
            buttonInfo_KVA = new Button();
            buttonSave_KVA = new Button();
            groupBox1 = new GroupBox();
            dataGridViewInput_KVA = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewOutput_KVA = new DataGridView();
            groupBoxCondition_KVA = new GroupBox();
            labelCondition_KVA = new Label();
            toolTip_KVA = new ToolTip(components);
            openFileDialogTask_KVA = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_KVA).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KVA).BeginInit();
            groupBoxCondition_KVA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpen_KVA
            // 
            buttonOpen_KVA.Image = (Image)resources.GetObject("buttonOpen_KVA.Image");
            buttonOpen_KVA.Location = new Point(12, 12);
            buttonOpen_KVA.Name = "buttonOpen_KVA";
            buttonOpen_KVA.Size = new Size(102, 76);
            buttonOpen_KVA.TabIndex = 0;
            buttonOpen_KVA.UseVisualStyleBackColor = true;
            buttonOpen_KVA.Click += buttonOpen_KVA_Click;
            buttonOpen_KVA.Enter += buttonOpen_KVA_MouseEnter;
            // 
            // buttonStart_KVA
            // 
            buttonStart_KVA.Enabled = false;
            buttonStart_KVA.Image = (Image)resources.GetObject("buttonStart_KVA.Image");
            buttonStart_KVA.Location = new Point(120, 12);
            buttonStart_KVA.Name = "buttonStart_KVA";
            buttonStart_KVA.Size = new Size(104, 76);
            buttonStart_KVA.TabIndex = 1;
            buttonStart_KVA.UseVisualStyleBackColor = true;
            buttonStart_KVA.Click += buttonStart_KVA_Click;
            buttonStart_KVA.Enter += buttonStart_KVA_MouseEnter;
            // 
            // buttonInfo_KVA
            // 
            buttonInfo_KVA.Image = (Image)resources.GetObject("buttonInfo_KVA.Image");
            buttonInfo_KVA.Location = new Point(684, 12);
            buttonInfo_KVA.Name = "buttonInfo_KVA";
            buttonInfo_KVA.Size = new Size(104, 76);
            buttonInfo_KVA.TabIndex = 2;
            buttonInfo_KVA.UseVisualStyleBackColor = true;
            buttonInfo_KVA.Click += buttonInfo_KVA_Click;
            buttonInfo_KVA.Enter += buttonInfo_KVA_MouseEnter;
            // 
            // buttonSave_KVA
            // 
            buttonSave_KVA.Enabled = false;
            buttonSave_KVA.Image = (Image)resources.GetObject("buttonSave_KVA.Image");
            buttonSave_KVA.Location = new Point(230, 12);
            buttonSave_KVA.Name = "buttonSave_KVA";
            buttonSave_KVA.Size = new Size(104, 76);
            buttonSave_KVA.TabIndex = 5;
            buttonSave_KVA.UseVisualStyleBackColor = true;
            buttonSave_KVA.Click += buttonSave_KVA_Click;
            buttonSave_KVA.Enter += buttonSave_KVA_MouseEnter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewInput_KVA);
            groupBox1.Location = new Point(18, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 399);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // dataGridViewInput_KVA
            // 
            dataGridViewInput_KVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_KVA.Enabled = false;
            dataGridViewInput_KVA.Location = new Point(17, 31);
            dataGridViewInput_KVA.Name = "dataGridViewInput_KVA";
            dataGridViewInput_KVA.RowHeadersWidth = 51;
            dataGridViewInput_KVA.Size = new Size(357, 362);
            dataGridViewInput_KVA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewOutput_KVA);
            groupBox2.Location = new Point(408, 211);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 399);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // dataGridViewOutput_KVA
            // 
            dataGridViewOutput_KVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_KVA.Enabled = false;
            dataGridViewOutput_KVA.Location = new Point(17, 31);
            dataGridViewOutput_KVA.Name = "dataGridViewOutput_KVA";
            dataGridViewOutput_KVA.RowHeadersWidth = 51;
            dataGridViewOutput_KVA.Size = new Size(357, 362);
            dataGridViewOutput_KVA.TabIndex = 1;
            // 
            // groupBoxCondition_KVA
            // 
            groupBoxCondition_KVA.Controls.Add(labelCondition_KVA);
            groupBoxCondition_KVA.Location = new Point(18, 94);
            groupBoxCondition_KVA.Name = "groupBoxCondition_KVA";
            groupBoxCondition_KVA.Size = new Size(770, 111);
            groupBoxCondition_KVA.TabIndex = 8;
            groupBoxCondition_KVA.TabStop = false;
            groupBoxCondition_KVA.Text = "Условие";
            // 
            // labelCondition_KVA
            // 
            labelCondition_KVA.AutoSize = true;
            labelCondition_KVA.Location = new Point(20, 32);
            labelCondition_KVA.Name = "labelCondition_KVA";
            labelCondition_KVA.Size = new Size(451, 20);
            labelCondition_KVA.TabIndex = 0;
            labelCondition_KVA.Text = "Дан файл, загрузить файл и изменить его. Сохранить результат";
            labelCondition_KVA.Click += label1_Click;
            // 
            // toolTip_KVA
            // 
            toolTip_KVA.Popup += toolTip_KVA_Popup;
            // 
            // openFileDialogTask_KVA
            // 
            openFileDialogTask_KVA.FileName = "openFileDialogTask_KVA";
            openFileDialogTask_KVA.FileOk += openFileDialog1_FileOk;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 622);
            Controls.Add(groupBoxCondition_KVA);
            Controls.Add(buttonSave_KVA);
            Controls.Add(buttonInfo_KVA);
            Controls.Add(buttonStart_KVA);
            Controls.Add(buttonOpen_KVA);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_KVA).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KVA).EndInit();
            groupBoxCondition_KVA.ResumeLayout(false);
            groupBoxCondition_KVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen_KVA;
        private Button buttonStart_KVA;
        private Button buttonInfo_KVA;
        private Button buttonSave_KVA;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBoxCondition_KVA;
        private Label labelCondition_KVA;
        private DataGridView dataGridViewInput_KVA;
        private DataGridView dataGridViewOutput_KVA;
        private ToolTip toolTip_KVA;
        private OpenFileDialog openFileDialogTask_KVA;
    }
}
