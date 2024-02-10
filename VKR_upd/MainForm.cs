using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKR_upd
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();

            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
