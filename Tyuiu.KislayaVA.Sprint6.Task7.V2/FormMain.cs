using Tyuiu.KislayaVA.Sprint6.Task7.V2.Lib;

namespace Tyuiu.KislayaVA.Sprint6.Task7.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeToolTips();
        }

        private void InitializeToolTips()
        {
            // Убедимся, что ToolTip создан
            if (toolTip_KVA == null)
            {
                toolTip_KVA = new ToolTip();
            }

            // Настройки ToolTip
            toolTip_KVA.AutoPopDelay = 5000;
            toolTip_KVA.InitialDelay = 500;
            toolTip_KVA.ReshowDelay = 500;
            toolTip_KVA.ShowAlways = true; // Важно: показывать всегда
            toolTip_KVA.IsBalloon = true; // В виде облачка

            // Устанавливаем подсказки для кнопок
            toolTip_KVA.SetToolTip(buttonOpen_KVA, "Выберите файл с данными для обработки");
            toolTip_KVA.SetToolTip(buttonStart_KVA, "Запустить выполнение задания");
            toolTip_KVA.SetToolTip(buttonSave_KVA, "Сохранить обработанные данные в файл");
            toolTip_KVA.SetToolTip(buttonInfo_KVA, "Показать информацию о программе и разработчике");
        }

        DataService ds = new DataService();

        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);


            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("тут спрятан прикол", "прикол найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_KVA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KVA.ShowDialog();
            openFilePath = openFileDialogTask_KVA.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_KVA.ColumnCount = columns;
            dataGridViewInput_KVA.RowCount = rows;
            dataGridViewInput_KVA.ColumnCount = columns;
            dataGridViewInput_KVA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_KVA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_KVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonStart_KVA.Enabled = true;

        }

        private void buttonStart_KVA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            dataGridViewOutput_KVA.ColumnCount = columns;
            dataGridViewOutput_KVA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutput_KVA.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_KVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_KVA.Enabled = true;
        }

        private void buttonSave_KVA_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_KVA_Click(object sender, EventArgs e)
        {
            // Новая форма с инфой
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        // Подсказки
        private void buttonOpen_KVA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KVA.ToolTipTitle = "Открыть файл";
            toolTip_KVA.SetToolTip(buttonOpen_KVA, "Выберите файл с данными для обработки");
        }

        private void buttonStart_KVA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KVA.ToolTipTitle = "Начать обработку";
            toolTip_KVA.SetToolTip(buttonStart_KVA, "Запустить выполнение задания");
        }

        private void buttonSave_KVA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KVA.ToolTipTitle = "Сохранить результат";
            toolTip_KVA.SetToolTip(buttonSave_KVA, "Сохранить обработанные данные в файл");
        }

        private void buttonInfo_KVA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KVA.ToolTipTitle = "О программе";
            toolTip_KVA.SetToolTip(buttonInfo_KVA, "Показать информацию о программе и разработчике");
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolTip_KVA_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
