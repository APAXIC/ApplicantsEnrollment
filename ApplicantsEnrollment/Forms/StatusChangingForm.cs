using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursass.Models;
using Kursass.Controllers;
using Newtonsoft.Json;

namespace Kursass.Forms
{
    public partial class StatusChangingForm : Form
    {
        ApplicationsManageForm previousForm;
        private Models.Application application;
        private List<Models.Application> applications;

        public StatusChangingForm(ApplicationsManageForm previousForm, Models.Application application, List<Models.Application> applications, string courseCode)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.application = application;
            this.applications = applications;
            StatusChanger.PopulateForm(application, applications, this, courseCode);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зміни не будуть збережені, ви справді хочете повернутися?", "Підтвердження дії", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            application.ApplicationStatus = statusComboBox.SelectedItem.ToString();
            RecommendingApplications.DeactivateLowerPriorityApplications(application, applications);
            StatusChanger.SaveApplicationToFile(application);
            ApplicationsManageForm form = new ApplicationsManageForm(previousForm.previousForm, previousForm.courseCode);
            form.Show();
            previousForm.Close();

            Close();
        }
    }
}
