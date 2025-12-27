using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KislayaVA.Sprint6.Task7.V2
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("до чего крутой скелет!", "прикол найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOKInfo_KVA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
