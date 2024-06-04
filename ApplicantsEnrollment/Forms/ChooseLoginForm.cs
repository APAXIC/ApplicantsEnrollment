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
    public partial class ChooseLoginForm : Form
    {
        GreetingForm greetingForm;

        public ChooseLoginForm(GreetingForm greetingForm)
        {
            InitializeComponent();
            this.greetingForm = greetingForm;
        }

        private void cancelLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm applicantLoginForm = new LoginForm(greetingForm, "applicant");
            applicantLoginForm.ShowDialog();
            Close();
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(greetingForm);
            greetingForm.Hide();
            registrationForm.ShowDialog();
            Close();
        }
    }
}
