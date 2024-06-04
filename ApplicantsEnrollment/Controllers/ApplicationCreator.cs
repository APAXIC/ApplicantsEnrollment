using Kursass.Forms;
using Kursass.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursass.Controllers
{
    internal class ApplicationCreator
    {
        public static bool LoadApplicantData(CreateApplicationForm form, out Applicant currentApplicant)
        {
            var applicantsList = new ApplicantsList();
            currentApplicant = applicantsList.Applicants.FirstOrDefault(a => a.Login == form.UserLogin);

            if (currentApplicant == null)
            {
                MessageBox.Show("Абітурієнта не знайдено.");
                return false;
            }

            form.Controls.Find("surnameTextBox", true).FirstOrDefault().Text = currentApplicant.Surname;
            form.Controls.Find("nameTextBox", true).FirstOrDefault().Text = currentApplicant.Name;
            form.Controls.Find("patronymicTextBox", true).FirstOrDefault().Text = currentApplicant.Patronymic;
            form.Controls.Find("ukrTextBox", true).FirstOrDefault().Text = currentApplicant.Grades.Ukrainian.ToString();
            form.Controls.Find("mathTextBox", true).FirstOrDefault().Text = currentApplicant.Grades.Math.ToString();

            string thirdSubject = GetThirdSubjectName(currentApplicant.Grades);
            var thirdSubjLabel = form.Controls.Find("thirdSubjLabel", true).FirstOrDefault() as Label;
            thirdSubjLabel.Text = thirdSubject;
            form.Controls.Find("thirdTextBox", true).FirstOrDefault().Text = GetThirdSubjectGrade(currentApplicant.Grades).ToString();

            return true;
        }

        public static bool LoadApplicationData(CreateApplicationForm form, Applicant currentApplicant, string courseCode)
        {
            var applicationsList = new ApplicationsList();
            var coursesList = new CoursesList();
            var currentApplication = applicationsList.Applications.FirstOrDefault(a => a.ApplicantId == currentApplicant.Id && a.Destination == courseCode);
            var currentCourse = coursesList.Courses.FirstOrDefault(c => c.Code == courseCode);

            if (currentCourse.IsClosed && currentApplication == null)
            {
                form.Controls.Find("submitButton", true).FirstOrDefault().Enabled = false;
                form.Controls.Find("label13", true).FirstOrDefault().Visible = true;
                form.Controls.Find("label13", true).FirstOrDefault().Text = "Набір на освітню програму закритий, ви не можете подати заяву";
                return false;
            }

            if (currentApplication != null)
            {
                form.Controls.Find("priorityComboBox", true).FirstOrDefault().Text = currentApplication.Priority;
                form.Controls.Find("courseNameTextBox", true).FirstOrDefault().Text = GetCourseName(courseCode);
                form.Controls.Find("contractReadyComboBox", true).FirstOrDefault().Text = currentApplication.ReadyForContract ? "Так" : "Ні";
                form.Controls.Find("canAffordComboBox", true).FirstOrDefault().Text = currentApplication.CanAffordContract ? "Так" : "Ні";

                MakeFieldsReadOnly(form);

                var submitButton = form.Controls.Find("submitButton", true).FirstOrDefault() as Button;
                submitButton.Text = "Підтвердити місце навчання";
                submitButton.Enabled = !currentApplication.IsConfirmed && (currentApplication.ApplicationStatus == "Рекомендовано (Бюджет)" || currentApplication.ApplicationStatus == "Рекомендовано (Контракт)");

                form.CurrentApplication = currentApplication;

                var label14 = form.Controls.Find("label14", true).FirstOrDefault() as Label;
                label14.Text = $"Статус поданої заяви: {currentApplication.ApplicationStatus}";
                label14.Visible = true;

                if (currentApplication.ApplicationStatus == "Рекомендовано (Бюджет)" || currentApplication.ApplicationStatus == "Рекомендовано (Контракт)")
                {
                    form.Controls.Find("label13", true).FirstOrDefault().Visible = true;
                    form.Controls.Find("label13", true).FirstOrDefault().Text = "Ви можете підтвердити вибір місця здобуття освіти";
                }

                return true;
            }
            else
            {
                form.Controls.Find("courseNameTextBox", true).FirstOrDefault().Text = GetCourseName(courseCode);
                PopulatePriorityComboBox(form, currentApplicant.Id);
                form.CurrentApplication = null;

                var submitButton = form.Controls.Find("submitButton", true).FirstOrDefault() as Button;
                submitButton.Text = "Подати заяву";
                return false;
            }
        }

        private static void MakeFieldsReadOnly(CreateApplicationForm form)
        {
            form.Controls.Find("surnameTextBox", true).FirstOrDefault().Enabled = false;
            form.Controls.Find("nameTextBox", true).FirstOrDefault().Enabled = false;
            form.Controls.Find("patronymicTextBox", true).FirstOrDefault().Enabled = false;
            form.Controls.Find("ukrTextBox", true).FirstOrDefault().Enabled = false;
            form.Controls.Find("mathTextBox", true).FirstOrDefault().Enabled = false;
            form.Controls.Find("thirdTextBox", true).FirstOrDefault().Enabled = false;
            form.Controls.Find("priorityComboBox", true).FirstOrDefault().Enabled = false;
            form.Controls.Find("courseNameTextBox", true).FirstOrDefault().Enabled = false;
            form.Controls.Find("contractReadyComboBox", true).FirstOrDefault().Enabled = false;
            form.Controls.Find("canAffordComboBox", true).FirstOrDefault().Enabled = false;
        }

        private static void PopulatePriorityComboBox(CreateApplicationForm form, string applicantId)
        {
            var applicationsList = new ApplicationsList();
            var usedPriorities = applicationsList.Applications
                .Where(a => a.ApplicantId == applicantId && a.Priority != "К")
                .Select(a => a.Priority)
                .ToList();

            var priorityComboBox = form.Controls.Find("priorityComboBox", true).FirstOrDefault() as ComboBox;
            var priorities = new List<string> { "1", "2", "3", "4", "5", "К" }
                .Where(p => !usedPriorities.Contains(p) || p == "К")
                .ToList();

            priorityComboBox.Items.Clear();
            priorityComboBox.Items.AddRange(priorities.ToArray());
        }

        private static string GetThirdSubjectName(Grades grades)
        {
            if (grades.English != 0) return "Іноземна мова";
            if (grades.History != 0) return "Історія України";
            if (grades.Physics != 0) return "Фізика";
            if (grades.Chemistry != 0) return "Хімія";
            if (grades.Biology != 0) return "Біологія";
            return "";
        }

        private static int GetThirdSubjectGrade(Grades grades)
        {
            if (grades.English != 0) return grades.English;
            if (grades.History != 0) return grades.History;
            if (grades.Physics != 0) return grades.Physics;
            if (grades.Chemistry != 0) return grades.Chemistry;
            if (grades.Biology != 0) return grades.Biology;
            return 0;
        }

        private static string GetCourseName(string courseCode)
        {
            var course = new CoursesList().Courses.FirstOrDefault(c => c.Code == courseCode);
            return course != null ? course.Name : "";
        }

        public static bool SubmitApplication(CreateApplicationForm form)
        {
            if (!ValidateFields(form))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return false;
            }

            var currentApplication = form.CurrentApplication;

            if (currentApplication != null)
            {
                currentApplication.IsConfirmed = true;
                ApplicationsList.SaveApplicationToFile(currentApplication);
                form.Controls.Find("submitButton", true).FirstOrDefault().Enabled = false;
                MessageBox.Show("Місце навчання підтверджено.");
            }
            else
            {
                var applicationsList = new ApplicationsList();
                var applicantsList = new ApplicantsList();
                var currentApplicant = applicantsList.Applicants.FirstOrDefault(a => a.Login == form.UserLogin);
                int newId = applicationsList.Applications.Any() ? applicationsList.Applications.Max(a => Int32.Parse(a.Id)) + 1 : 1;

                var newApplication = new Models.Application
                {
                    Id = newId.ToString(),
                    ApplicantId = form.CurrentApplicant.Id,
                    Destination = form.CourseCode,
                    Surname = currentApplicant.Surname,
                    Name = currentApplicant.Name,
                    Patronymic = currentApplicant.Patronymic,
                    Priority = form.Controls.Find("priorityComboBox", true).FirstOrDefault().Text,
                    ApplicationStatus = "Допущено",
                    ReadyForContract = form.Controls.Find("contractReadyComboBox", true).FirstOrDefault().Text == "Так",
                    CanAffordContract = form.Controls.Find("canAffordComboBox", true).FirstOrDefault().Text == "Так",
                    Grades = form.CurrentApplicant.Grades
                };

                applicationsList.Applications.Add(newApplication);
                SaveToFile(applicationsList);
                MessageBox.Show("Заяву успішно подано.");
                form.PreviousForm.Show();
                form.Close();
            }

            return true;
        }

        private static bool ValidateFields(CreateApplicationForm form)
        {
            return !string.IsNullOrEmpty(form.Controls.Find("priorityComboBox", true).FirstOrDefault().Text) &&
                   !string.IsNullOrEmpty(form.Controls.Find("contractReadyComboBox", true).FirstOrDefault().Text) &&
                   !string.IsNullOrEmpty(form.Controls.Find("canAffordComboBox", true).FirstOrDefault().Text);
        }

        private static void SaveToFile(ApplicationsList applicationsList)
        {
            string filePath = @"..\..\..\Data\applications.json";
            string json = JsonConvert.SerializeObject(applicationsList.Applications, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void UpdateComboboxesBasedOnPriority(CreateApplicationForm form)
        {
            var priorityComboBox = form.Controls.Find("priorityComboBox", true).FirstOrDefault() as ComboBox;
            var contractReadyComboBox = form.Controls.Find("contractReadyComboBox", true).FirstOrDefault() as ComboBox;
            var canAffordComboBox = form.Controls.Find("canAffordComboBox", true).FirstOrDefault() as ComboBox;

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

        public static void UpdateCanAffordContractCombobox(CreateApplicationForm form)
        {
            var contractReadyComboBox = form.Controls.Find("contractReadyComboBox", true).FirstOrDefault() as ComboBox;
            var canAffordComboBox = form.Controls.Find("canAffordComboBox", true).FirstOrDefault() as ComboBox;

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
    }
}
