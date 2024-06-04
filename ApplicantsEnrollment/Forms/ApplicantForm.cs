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
    public partial class ApplicantForm : Form
    {
        private GreetingForm greetingForm;
        private string userLogin;
        public ApplicantForm(GreetingForm greetingForm, string login)
        {
            InitializeComponent();
            this.greetingForm = greetingForm;
            this.userLogin = login;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            greetingForm.Show();
            Close();
        }

        private void mathApplicationButton_Click(object sender, EventArgs e)
        {
            OpenCreateApplicationForm("math");
        }

        private void piApplicationButton_Click(object sender, EventArgs e)
        {
            OpenCreateApplicationForm("pi");
        }

        private void infoApplicationButton_Click(object sender, EventArgs e)
        {
            OpenCreateApplicationForm("info");
        }

        private void aiApplicationButton_Click(object sender, EventArgs e)
        {
            OpenCreateApplicationForm("ai");
        }

        private void ciApplicationButton_Click(object sender, EventArgs e)
        {
            OpenCreateApplicationForm("ci");
        }

        private void safeApplicationButton_Click(object sender, EventArgs e)
        {
            OpenCreateApplicationForm("safe");
        }

        private void OpenCreateApplicationForm(string courseCode)
        {
            CreateApplicationForm createApplicationForm = new CreateApplicationForm(this, userLogin, courseCode);
            createApplicationForm.Show();
            this.Hide();
        }

        private void ApplicantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            greetingForm.Show();
        }
    }
}
