using Kursass.Models;
using Kursass.Controllers;
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
    public partial class RecommendMultipleForm : Form
    {
        private ApplicationsManageForm previousForm;
        private List<Models.Application> applications;
        private string courseCode;

        public RecommendMultipleForm(ApplicationsManageForm previousForm, List<Models.Application> applications, string courseCode)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.applications = applications;
            this.courseCode = courseCode;

            recommendTypeComboBox.Items.AddRange(new string[] { "Бюджет", "Контракт" });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int count;
            if (int.TryParse(numberTextBox.Text, out count) && count > 0)
            {
                string recommendType = recommendTypeComboBox.SelectedItem.ToString();
                if (RecommendingApplications.Recommend(applications, courseCode, count, recommendType))
                {
                    ApplicationsManageForm form = new ApplicationsManageForm(previousForm.previousForm, previousForm.courseCode);
                    form.Show();
                    previousForm.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректне число.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зміни не будуть збережені, ви справді хочете повернутися?", "Підтвердження дії", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
