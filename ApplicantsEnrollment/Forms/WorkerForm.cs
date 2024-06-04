using Kursass.Controllers;
using Kursass.Models;
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
    public partial class WorkerForm : Form
    {
        private GreetingForm greetingForm;

        public WorkerForm(GreetingForm greetingForm)
        {
            InitializeComponent();
            this.greetingForm = greetingForm;
        }

        private void workerExitButton_Click(object sender, EventArgs e)
        {
            greetingForm.Show();
            Close();
        }

        private void mathApplications_Click(object sender, EventArgs e)
        {
            ApplicationsManageForm applicationsManageForm = new ApplicationsManageForm(this, "math");
            applicationsManageForm.Show();
            Hide();
        }

        private void piApplications_Click(object sender, EventArgs e)
        {
            ApplicationsManageForm applicationsManageForm = new ApplicationsManageForm(this, "pi");
            applicationsManageForm.Show();
            Hide();
        }

        private void infoApplications_Click(object sender, EventArgs e)
        {
            ApplicationsManageForm applicationsManageForm = new ApplicationsManageForm(this, "info");
            applicationsManageForm.Show();
            Hide();
        }

        private void aiApplication_Click(object sender, EventArgs e)
        {
            ApplicationsManageForm applicationsManageForm = new ApplicationsManageForm(this, "ai");
            applicationsManageForm.Show();
            Hide();
        }

        private void engineeringApplication_Click(object sender, EventArgs e)
        {
            ApplicationsManageForm applicationsManageForm = new ApplicationsManageForm(this, "ci");
            applicationsManageForm.Show();
            Hide();
        }

        private void safetyApplication_Click(object sender, EventArgs e)
        {
            ApplicationsManageForm applicationsManageForm = new ApplicationsManageForm(this, "safe");
            applicationsManageForm.Show();
            Hide();
        }

        private void makeBudgetedButton_Click(object sender, EventArgs e)
        {
            RecommendationFinisher.RecommendAllToBudget();
        }

        private void makeContractedButton_Click(object sender, EventArgs e)
        {
            RecommendationFinisher.RecommendAllToContract();
        }

        private void generateOrderButton_Click(object sender, EventArgs e)
        {
            RecommendationFinisher.GenerateOrder();
        }

        private void interviewListButton_Click(object sender, EventArgs e)
        {
            FileSaver.GenerateInterviewList();
        }

        private void WorkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            greetingForm.Show();
        }
    }
}
