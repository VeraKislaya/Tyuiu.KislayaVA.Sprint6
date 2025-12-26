using Tyuiu.KislayaVA.Sprint6.Task1.V29.Lib;

namespace Tyuiu.KislayaVA.Sprint6.Task1.V29
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
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 РППб25-1 Кислая В.А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxEnd.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxFunc.Text = "";
                textBoxFunc.AppendText("---------+--------------" + Environment.NewLine);
                textBoxFunc.AppendText("|     X  |     f(x)    |" + Environment.NewLine);
                textBoxFunc.AppendText("---------+--------------" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |    {1,6:f2}   |", startValue, valueArray[i]);
                    textBoxFunc.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxFunc.AppendText("---------+--------------" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxFunc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}