using Kursass.Controllers;
using Kursass.Models;
using Newtonsoft.Json;
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
    public partial class RegistrationForm : Form
    {
        public GreetingForm GreetingForm;
        private ApplicantsList applicantsList;

        public RegistrationForm(GreetingForm greetingForm)
        {
            InitializeComponent();
            applicantsList = new ApplicantsList();
            this.GreetingForm = greetingForm;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Registrator.RegisterApplicant(applicantsList, this);
        }



        private void backButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зміни не будуть збережені, ви справді хочете повернутися?", "Підтвердження дії", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GreetingForm.Show();
                Close();
            }
        }
    }
}
