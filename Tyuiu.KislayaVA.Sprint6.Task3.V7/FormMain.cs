using System.Windows.Forms;
using Tyuiu.KislayaVA.Sprint6.Task3.V7.Lib;
namespace Tyuiu.KislayaVA.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] {{ 31,  25,  -18,  12,   9 },
                                       {  6,  34,   -2,   2,  -18},
                                       { -5,   4,   27,   4,  -1 },
                                       {  4,  15,   34,  -6,  -10},
                                       {  0,   8,    5,  14,  -17} };
        private void buttonDone_Click(object sender, EventArgs e) 
        {
            int[,] res = ds.Calculate(matrix);
            int rows = res.GetUpperBound(0) + 1;
            int coll = res.Length / rows;
            dataGridViewDone.ColumnCount = coll;
            dataGridViewDone.RowCount = rows;
            for (int i = 0; i < coll; i++)
            {
                dataGridViewDone.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    dataGridViewDone.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("таск 3 РППб25-1 Кислая В. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
