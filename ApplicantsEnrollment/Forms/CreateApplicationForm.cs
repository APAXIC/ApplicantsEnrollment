using Kursass.Controllers;
using Kursass.Models;
using Microsoft.VisualBasic.Devices;
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
    public partial class CreateApplicationForm : Form
    {
        public ApplicantForm PreviousForm;
        public string UserLogin;
        public string CourseCode;
        public Applicant CurrentApplicant;
        public Models.Application CurrentApplication;

        public CreateApplicationForm(ApplicantForm previousForm, string login, string courseCode)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            UserLogin = login;
            CourseCode = courseCode;

            if (!ApplicationCreator.LoadApplicantData(this, out CurrentApplicant))
            {
                this.Close();
                return;
            }

            ApplicationCreator.LoadApplicationData(this, CurrentApplicant, courseCode);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            ApplicationCreator.SubmitApplication(this);
        }

        private void priorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (priorityComboBox.Text == "К")
            {
                contractReadyComboBox.SelectedIndex = contractReadyComboBox.Items.IndexOf("Так");
                canAffordComboBox.SelectedIndex = canAffordComboBox.Items.IndexOf("Так");

                contractReadyComboBox.Enabled = false;
                canAffordComboBox.Enabled = false;
            }
            else
            {
                contractReadyComboBox.SelectedIndex = contractReadyComboBox.Items.IndexOf("Ні");
                canAffordComboBox.SelectedIndex = canAffordComboBox.Items.IndexOf("Ні");

                contractReadyComboBox.Enabled = true;
                canAffordComboBox.Enabled = false;
            }
        }

        private void readyForContractComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contractReadyComboBox.Text == "Так")
            {
                canAffordComboBox.Enabled = true;
            }
            else
            {
                canAffordComboBox.SelectedIndex = canAffordComboBox.Items.IndexOf("Ні");
                canAffordComboBox.Enabled = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зміни не будуть збережені, ви справді хочете повернутися?", "Підтвердження дії", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PreviousForm.Show();
                Close();
            }
        }

        private void CreateApplicationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PreviousForm.Show();
        }
    }
}
