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
using static System.Net.Mime.MediaTypeNames;

namespace Kursass.Forms
{
    public partial class ApplicationsManageForm : Form
    {
        public WorkerForm previousForm { get; private set; }
        public string courseCode { get; private set; }
        private PanelManager panelManager;
        private List<Models.Application> applications;

        public ApplicationsManageForm(WorkerForm previousForm, string courseCode)
        {
            InitializeComponent();
            this.courseCode = courseCode;
            this.previousForm = previousForm;
            panelManager = new PanelManager(this, courseCode);
            panelManager.CreateScrollablePanel();
            List<Panel> panels = panelManager.CreateDynamicPanels();
            applications = panelManager.GetFilteredApplications();
            panelManager.FillCourseDetails();

            foreach (var panel in panels)
            {
                panel.DoubleClick += Panel_DoubleClick;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            Close();
        }

        private void Panel_DoubleClick(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                foreach (Control control in clickedPanel.Controls)
                {
                    if (control is Label label && label.Tag != null && label.Tag.ToString() == "NumberLabel")
                    {
                        int index = int.Parse(label.Text) - 1;
                        OpenStatusChangingForm(applications[index]);
                        break;
                    }
                }
            }
        }

        private void OpenStatusChangingForm(Models.Application application)
        {
            StatusChangingForm form = new StatusChangingForm(this, application, applications, courseCode);
            form.ShowDialog();
        }

        private void closeSelectionButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Це рішення не можна буде змінити, ви хочете продовжити?", "Підтвердження дії", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CourseCloser.CloseCourse(courseCode);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            panelManager.SearchPanels(searchTextBox.Text);
        }

        private void recommendMultipleButton_Click(object sender, EventArgs e)
        {
            var course = new CoursesList().Courses.FirstOrDefault(c => c.Code == courseCode);
            if (course.IsClosed)
            {
                RecommendMultipleForm recommendForm = new RecommendMultipleForm(this, applications, courseCode);
                recommendForm.ShowDialog();
            }
            else MessageBox.Show("Не можна починати рекомендувати, пока набір не буде закрито!");
        }
    }
}
