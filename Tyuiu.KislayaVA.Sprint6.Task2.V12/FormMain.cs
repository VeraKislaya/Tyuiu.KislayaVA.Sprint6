using Tyuiu.KislayaVA.Sprint6.Task2.V12.Lib;
namespace Tyuiu.KislayaVA.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 РППб25-1 Кислая В.А. ", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStart.Text);
                double[] ans = ds.GetMassFunction(Convert.ToInt32(textBoxStart.Text), Convert.ToInt32(textBoxStop.Text));

                this.chartFunc.Titles.Clear();
                this.chartFunc.Titles.Add("sin(x)");
                this.chartFunc.ChartAreas[0].AxisX.Title = "X";
                this.chartFunc.ChartAreas[0].AxisY.Title = "Y";

                this.dataGridFunc.Rows.Clear();

                for (int i = 0; i < ans.Length; i++)
                {
                    this.dataGridFunc.Rows.Add(startstep, Convert.ToString(ans[i]));
                    this.chartFunc.Series[0].Points.AddXY(startstep, ans[i]);
                    startstep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
