using Tyuiu.KislayaVA.Sprint6.Task4.V7.Lib;
namespace Tyuiu.KislayaVA.Sprint6.Task4.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] array = new double[len];

                array = ds.GetMassFunction(startStep, stopStep);

                this.chartFunc.ChartAreas[0].AxisX.Title = "X";
                this.chartFunc.ChartAreas[0].AxisY.Title = "Y";

                textBox3.Text = "";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunc.Series[0].Points.AddXY(startStep, array[i]);

                    textBox3.AppendText(array[i] + Environment.NewLine);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4v7.txt";
                File.WriteAllText(path, textBox3.Text);

                DialogResult dialogResult = MessageBox.Show("По адресу будет " + path , "Сохранить?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Что то пошло не так!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 РППБ25-1 Кислая В.А. ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
