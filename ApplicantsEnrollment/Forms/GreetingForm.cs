using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursass.Forms
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GreetingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void workerButton_Click(object sender, EventArgs e)
        {
            LoginForm workerLoginForm = new LoginForm(this, "worker");
            workerLoginForm.ShowDialog();
        }

        private void applicantButton_Click(object sender, EventArgs e)
        {
            ChooseLoginForm chooseLoginForm = new ChooseLoginForm(this);
            chooseLoginForm.ShowDialog();
        }
    }
}
