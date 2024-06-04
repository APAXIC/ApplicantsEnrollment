using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursass.Forms;
using Kursass.Models;
using Newtonsoft.Json;

namespace Kursass.Controllers
{
    internal class StatusChanger
    {
        public static void PopulateForm(Models.Application application, List<Models.Application> applications, Form form, string courseCode)
        {
            TextBox nameTextBox = form.Controls.Find("nameTextBox", true).FirstOrDefault() as TextBox;
            TextBox contractBox1 = form.Controls.Find("contractBox1", true).FirstOrDefault() as TextBox;
            TextBox contractBox2 = form.Controls.Find("contractBox2", true).FirstOrDefault() as TextBox;
            TextBox priorityBox = form.Controls.Find("priorityBox", true).FirstOrDefault() as TextBox;
            TextBox averageGradeBox = form.Controls.Find("averageGradeBox", true).FirstOrDefault() as TextBox;
            TextBox ukrBox = form.Controls.Find("ukrBox", true).FirstOrDefault() as TextBox;
            TextBox mathBox = form.Controls.Find("mathBox", true).FirstOrDefault() as TextBox;
            Label thirdGradeLabel = form.Controls.Find("thirdGradeLabel", true).FirstOrDefault() as Label;
            TextBox thirdGradeBox = form.Controls.Find("thirdGradeBox", true).FirstOrDefault() as TextBox;
            ComboBox statusComboBox = form.Controls.Find("statusComboBox", true).FirstOrDefault() as ComboBox;

            nameTextBox.Text = $"{application.Surname} {application.Name} {application.Patronymic}";
            contractBox1.Text = application.ReadyForContract ? "Так" : "Ні";
            contractBox2.Text = application.CanAffordContract ? "Так" : "Ні";
            priorityBox.Text = application.Priority;
            averageGradeBox.Text = application.AverageGrade.ToString("N2");
            ukrBox.Text = application.Grades.Ukrainian.ToString();
            mathBox.Text = application.Grades.Math.ToString();
            thirdGradeLabel.Text = application.Grades.English != 0 ? "Іноземна мова" :
                          application.Grades.History != 0 ? "Історія України" :
                          application.Grades.Physics != 0 ? "Фізика" :
                          application.Grades.Chemistry != 0 ? "Хімія" : "Біологія";
            thirdGradeBox.Text = application.Grades.English != 0 ? application.Grades.English.ToString() :
                              application.Grades.History != 0 ? application.Grades.History.ToString() :
                              application.Grades.Physics != 0 ? application.Grades.Physics.ToString() :
                              application.Grades.Chemistry != 0 ? application.Grades.Chemistry.ToString() : application.Grades.Biology.ToString();


            if (statusComboBox != null)
            {
                statusComboBox.Items.Clear();
                statusComboBox.Items.AddRange(new string[] { "Рекомендовано (Бюджет)", "Рекомендовано (Контракт)", "Допущено", "Відмова" });
                statusComboBox.SelectedItem = application.ApplicationStatus;

                if (application.ApplicationStatus == "Рекомендовано (Бюджет)" || application.ApplicationStatus == "Рекомендовано (Контракт)" || application.ApplicationStatus == "Відмова")
                {
                    statusComboBox.Enabled = false;
                }
            }

            SetStatusOptions(application, applications, form, courseCode);
        }

        private static void SetStatusOptions(Models.Application application, List<Models.Application> applications, Form form, string courseCode)
        {
            ComboBox statusComboBox = form.Controls.Find("statusComboBox", true).FirstOrDefault() as ComboBox;
            if (statusComboBox == null) return;

            var course = new CoursesList().Courses.FirstOrDefault(c => c.Code == courseCode);

            int index = applications.IndexOf(application);

            int budgetCount = applications.Count(a => a.ApplicationStatus == "Рекомендовано (Бюджет)");
            int contractCount = applications.Count(a => a.ApplicationStatus == "Рекомендовано (Контракт)");

            bool canSetBudget = true;
            bool canSetContract = true;

            if (budgetCount >= course.BudgetLimit) canSetBudget = false;
            if (application.Priority == "К") canSetBudget = false;
            if (index != 0 && applications[index - 1].ApplicationStatus == "Допущено") 
            { 
                for (int i = index - 1; i >= 0; i--)
                {
                    if (applications[i].Priority != "К" && applications[i].ApplicationStatus == "Допущено")
                    {
                        canSetBudget = false;
                        break;
                    }
                    else if (applications[i].ApplicationStatus == "Рекомендовано (Бюджет)") break;
                }
            }
            if (contractCount >= course.ContractLimit) canSetContract = false;
            if (index != 0 && applications[index - 1].ApplicationStatus == "Допущено") canSetContract = false;
            if (index != 0 && applications[index - 1].ApplicationStatus == "Рекомендовано (Бюджет)" && budgetCount < 10 && application.Priority != "К") canSetContract = false;
            if (index != 0 && applications[index - 1].ApplicationStatus == "Рекомендовано (Контракт)" && budgetCount < 10 && application.Priority != "К") canSetContract = false;
            if (index == 0 && application.Priority != "К") canSetContract = false;
            if (!course.IsClosed)
            {
                canSetBudget = false;
                canSetContract = false;
            }
            if (!course.IsBudgeted) canSetContract = false;

            if (!canSetBudget)
            {
                if (application.ApplicationStatus != "Рекомендовано (Бюджет)")
                {
                    statusComboBox.Items.Remove("Рекомендовано (Бюджет)");
                }
            }
            if (!canSetContract)
            {
                if (application.ApplicationStatus != "Рекомендовано (Контракт)")
                {
                    statusComboBox.Items.Remove("Рекомендовано (Контракт)");
                }
            }
        }

        public static void SaveApplicationToFile(Models.Application application)
        {
            string filePath = @"..\..\..\Data\applications.json";

            List<Models.Application> allApplications;
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                allApplications = JsonConvert.DeserializeObject<List<Models.Application>>(json);
            }
            else
            {
                allApplications = new List<Models.Application>();
            }

            var existingApplication = allApplications.FirstOrDefault(a => a.Id == application.Id);
            if (existingApplication != null)
            {
                existingApplication.ApplicationStatus = application.ApplicationStatus;
            }

            string updatedJson = JsonConvert.SerializeObject(allApplications, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }
    }
}
