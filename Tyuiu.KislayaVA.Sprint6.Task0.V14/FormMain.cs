using Tyuiu.KislayaVA.Sprint6.Task0.V14.Lib;
namespace Tyuiu.KislayaVA.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_KVA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxDone_KVA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxEnter_KVA.Text)));
            }
            catch
            {
                MessageBox.Show("Введено неверное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 РППб25-1 Кислая В. А.", "Информация", MessageBoxButtons.OK);
        }
        private void textBoxEnter_KVA_TextChanged(object sender, EventArgs e)
        { 

        }
    }
}
