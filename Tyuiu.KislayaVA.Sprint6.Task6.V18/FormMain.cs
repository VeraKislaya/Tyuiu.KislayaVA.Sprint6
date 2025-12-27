using Tyuiu.KislayaVA.Sprint6.Task6.V18.Lib;
namespace Tyuiu.KislayaVA.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;

        private void buttonOpen_Click(object sender, EventArgs e)
        {

            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("таск 6 РППб25-1 Кислая В. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
