using System;
using System.Windows.Forms;

namespace PointOfSales
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            uPass.PasswordChar = '*';
        }

        //On clicking login buttons, checks credentials and navigates to POS form
        private void iLogin_Click(object sender, EventArgs e)
        {
            if (uName.Text == "SaiSantosh" && uPass.Text == "Matrix") {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Incorrect Username/Password. Login Denied ", " Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Shows message if user hits forgot password
        private void fPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Sorry! I don't have a Database ", "InConvenience", MessageBoxButtons.OK);

        }
    }
}
