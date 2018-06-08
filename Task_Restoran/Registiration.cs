using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Restoran
{
    public partial class Registiration : Form
    {
        public Registiration()
        {
            InitializeComponent();
        }

        Login login = new Login();
        private void button1_Click(object sender, EventArgs e)
        {
            if(txbx_user.Text == login.Name && txbx_password.Text == login.Password)
            {
                MainForm mainform = new MainForm(this);
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong!");
            }
        }
    }
}
