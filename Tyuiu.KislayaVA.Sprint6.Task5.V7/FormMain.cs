using Tyuiu.KislayaVA.Sprint6.Task5.V7.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.KislayaVA.Sprint6.Task5.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                chart1.Series[0].Points.Clear();
                dataGridView1.Rows.Clear();


                if (chart1.Titles.Count == 0)
                {
                    chart1.Titles.Add("График");
                }

                string path = "C:\\Users\\Вера Кислая\\source\\repos\\Tyuiu.KislayaVA.Sprint6\\Files\\InPutDataFileTask5V7.txt";
                double[] res = ds.LoadFromDataFile(path);
                int len = res.Length;

                for (int i = 0; i < len; i++)
                {
                    dataGridView1.Rows.Add(Convert.ToString(res[i]));
                    chart1.Series[0].Points.AddXY(i, res[i]);
                }
            }
            catch
            {
                MessageBox.Show("Что то пошло не так!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Вера Кислая\\source\\repos\\Tyuiu.KislayaVA.Sprint6\\Files\\InPutDataFileTask5V7.txt";
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("таск 5 РППб25-1 Кислая В. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
