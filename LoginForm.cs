using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0 && txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Username and Password cannot be blank!!!");
                txtUsername.Focus();
            }
            else if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Username cannot be blank!!!");
                txtUsername.Focus();
            }

            else if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Password cannot be blank!!!");
                txtPassword.Focus();
            }
            else if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Your Password must be 8 character!!!");
                txtPassword.Clear();
                txtPassword.Focus();
            }
            frmMainform f2 = new frmMainform();
            f2.ShowDialog(); // Shows Form2
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
