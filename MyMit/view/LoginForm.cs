using MyMit.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMit.view
{
    public partial class LoginForm : Form
    {
        MyMitController controller = null;

        public LoginForm()
        {
            InitializeComponent();
            this.controller = new MyMitController();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            int usr_id = this.controller.verifyUserAccess(this.textBoxEmail.Text, this.textBoxPassword.Text);

            if (!(usr_id > 0))
                MessageBox.Show("Wrong Username/password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else {
                this.Hide();
                _ = new FormMyMit(usr_id).ShowDialog();
                this.Close();
            }

        }
    }
}
