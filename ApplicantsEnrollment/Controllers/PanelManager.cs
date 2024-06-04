using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursass.Forms;
using Kursass.Models;

namespace Kursass.Controllers
{
    internal class PanelManager
    {
        private Panel scrollablePanel;
        private ApplicationsList applicationsList;
        private BindingSource bindingSource;
        private ApplicationsManageForm form;
        private CoursesList coursesList;
        private string destination;

        private static readonly Dictionary<string, int> ApplicationStatusOrder = new Dictionary<string, int>
        {
            { "До наказу (Бюджет)", 1 },
            { "До наказу (Контракт)", 2 },
            { "Рекомендовано (Бюджет)", 3 },
            { "Рекомендовано (Контракт)", 4 },
            { "До співбесіди", 5 },
            { "Допущено", 6 },
            { "Відхилено (Бюджет)", 7 },
            { "Відхилено (Контракт)", 8 },
            { "Деактивовано", 9 },
            { "Відмова", 10 }
        };

        private static readonly Dictionary<string, int> ApplicationPriorityOrder = new Dictionary<string, int>
        {
            { "1", 1 },
            { "2", 2 },
            { "3", 3 },
            { "4", 4 },
            { "5", 5 },
            { "К", 6 }
        };

        public PanelManager(ApplicationsManageForm form, string destination)
        {
            this.form = form;
            this.destination = destination;
            applicationsList = new ApplicationsList();
            coursesList = new CoursesList();
            var filteredApplications = applicationsList.Applications
            .Where(a => a.Destination == destination)
            .OrderBy(a => ApplicationStatusOrder.ContainsKey(a.ApplicationStatus) ? ApplicationStatusOrder[a.ApplicationStatus] : int.MaxValue)
            .ThenByDescending(a => a.AverageGrade)
            .ThenBy(a => a.Priority)
            .ToList();
            bindingSource = new BindingSource
            {
                DataSource = filteredApplications
            };
        }

        public void FillCourseDetails()
        {
            var course = coursesList.Courses.FirstOrDefault(c => c.Code == destination);
            if (course != null)
            {
                Label label1 = form.Controls.Find("label1", true).FirstOrDefault() as Label;
                TextBox budgetLimitBox = form.Controls.Find("budgetLimitBox", true).FirstOrDefault() as TextBox;
                TextBox contractLimitBox = form.Controls.Find("contractLimitBox", true).FirstOrDefault() as TextBox;
                TextBox ukrCoefBox = form.Controls.Find("ukrCoefBox", true).FirstOrDefault() as TextBox;
                TextBox mathCoefBox = form.Controls.Find("mathCoefBox", true).FirstOrDefault() as TextBox;
                TextBox engCoefBox = form.Controls.Find("engCoefBox", true).FirstOrDefault() as TextBox;
                TextBox histCoefBox = form.Controls.Find("histCoefBox", true).FirstOrDefault() as TextBox;
                TextBox physCoefBox = form.Controls.Find("physCoefBox", true).FirstOrDefault() as TextBox;
                TextBox chemCoefBox = form.Controls.Find("chemCoefBox", true).FirstOrDefault() as TextBox;
                TextBox bioCoefBox = form.Controls.Find("bioCoefBox", true).FirstOrDefault() as TextBox;

                label1.Text = $"{course.Number}. {course.Name}";
                label1.Left = (600 - label1.Width) / 2;
                budgetLimitBox.Text = course.BudgetLimit.ToString();
                contractLimitBox.Text = course.ContractLimit.ToString();
                ukrCoefBox.Text = course.Coefficients.Ukrainian.ToString();
                mathCoefBox.Text = course.Coefficients.Math.ToString();
                engCoefBox.Text = course.Coefficients.English.ToString();
                histCoefBox.Text = course.Coefficients.History.ToString();
                physCoefBox.Text = course.Coefficients.Physics.ToString();
                chemCoefBox.Text = course.Coefficients.Chemistry.ToString();
                bioCoefBox.Text = course.Coefficients.Biology.ToString();
            }
        }

        public List<Models.Application> GetFilteredApplications()
        {
            return (List<Models.Application>)bindingSource.DataSource;
        }

        public void CreateScrollablePanel()
        {
            scrollablePanel = new Panel
            {
                AutoScroll = true,
                Width = 630,
                Height = 500,
                Top = 330,
                Left = 130,
                Dock = DockStyle.Fill
            };
            scrollablePanel.Left = (form.Width - scrollablePanel.Width) / 2;
            scrollablePanel.Anchor = AnchorStyles.Top;
            form.Controls.Add(scrollablePanel);
        }

        public List<Panel> CreateDynamicPanels()
        {
            int panelHeight = 50;
            int panelWidth = 600;
            int spacing = 10;
            List<Panel> panels = new List<Panel>();

            for (int i = 0; i < bindingSource.Count; i++)
            {
                Panel panel = new Panel
                {
                    Width = panelWidth,
                    Height = panelHeight,
                    Top = ((panelHeight + spacing) * i) + spacing,
                    Left = spacing,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label numberLabel = new Label
                {
                    Text = (i + 1).ToString(),
                    AutoSize = true,
                    Left = 10,
                    Top = panel.Height / 2 - 10,
                    Tag = "NumberLabel"
                };
                Label surnameLabel = CreateBoundLabel("Surname", 40, panel.Height / 2 - 10);
                Label statusLabel = CreateBoundLabel("ApplicationStatus", 150, panel.Height / 2 - 10);
                Label priorityLabel = CreateBoundLabel("Priority", 350, panel.Height / 2 - 10);
                Label averageGradeLabel = CreateBoundLabel("AverageGrade", 460, panel.Height / 2 - 10);
                CheckBox isConfirmedCheckBox = new CheckBox
                {
                    Left = 550,
                    Top = panel.Height / 2 - 14,
                    Enabled = false,
                    AutoCheck = false
                };

                panel.Controls.Add(numberLabel);
                panel.Controls.Add(surnameLabel);
                panel.Controls.Add(statusLabel);
                panel.Controls.Add(priorityLabel);
                panel.Controls.Add(averageGradeLabel);
                panel.Controls.Add(isConfirmedCheckBox);
                scrollablePanel.Controls.Add(panel);

                surnameLabel.DataBindings.Clear();
                surnameLabel.DataBindings.Add("Text", bindingSource[i], "Surname");
                statusLabel.DataBindings.Clear();
                statusLabel.DataBindings.Add("Text", bindingSource[i], "ApplicationStatus");
                priorityLabel.DataBindings.Clear();
                priorityLabel.DataBindings.Add("Text", bindingSource[i], "Priority");
                averageGradeLabel.DataBindings.Clear();
                averageGradeLabel.DataBindings.Add("Text", bindingSource[i], "AverageGrade", true, DataSourceUpdateMode.OnPropertyChanged, null, "F2");
                isConfirmedCheckBox.DataBindings.Clear();
                isConfirmedCheckBox.DataBindings.Add(new Binding("Checked", bindingSource[i], "isConfirmed", true, DataSourceUpdateMode.OnPropertyChanged));

                panels.Add(panel);
            }

            return panels;
        }

        private Label CreateBoundLabel(string dataMember, int left, int top)
        {
            Label label = new Label
            {
                AutoSize = true,
                Left = left,
                Top = top
            };
            label.DataBindings.Clear();
            label.DataBindings.Add(new Binding("Text", bindingSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged));
            return label;
        }

        public void SearchPanels(string searchText)
        {
            var filteredApplications = applicationsList.Applications
                .Where(a => a.Destination == destination && a.Surname.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .OrderBy(a => ApplicationStatusOrder.ContainsKey(a.ApplicationStatus) ? ApplicationStatusOrder[a.ApplicationStatus] : int.MaxValue)
                .ThenByDescending(a => a.AverageGrade)
                .ThenBy(a => a.Priority)
                .ToList();
            bindingSource.DataSource = filteredApplications;

            scrollablePanel.Controls.Clear();

            CreateDynamicPanels();
        }
    }
}
