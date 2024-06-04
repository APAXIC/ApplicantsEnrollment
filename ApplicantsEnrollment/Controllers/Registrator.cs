using Kursass.Forms;
using Kursass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursass.Controllers
{
    internal class Registrator
    {
        public static bool RegisterApplicant(ApplicantsList applicantsList, RegistrationForm form)
        {
            int ukrGrade;
            int mathGrade;
            int thirdSubjectGrade;

            TextBox surnameTextBox = form.Controls.Find("surnameTextBox", true).FirstOrDefault() as TextBox;
            TextBox nameTextBox = form.Controls.Find("nameTextBox", true).FirstOrDefault() as TextBox;
            TextBox patronymicTextBox = form.Controls.Find("patronymicTextBox", true).FirstOrDefault() as TextBox;
            TextBox ukrTextBox = form.Controls.Find("ukrTextBox", true).FirstOrDefault() as TextBox;
            TextBox mathTextBox = form.Controls.Find("mathTextBox", true).FirstOrDefault() as TextBox;
            ComboBox thirdComboBox = form.Controls.Find("thirdComboBox", true).FirstOrDefault() as ComboBox;
            TextBox thirdTextBox = form.Controls.Find("thirdTextBox", true).FirstOrDefault() as TextBox;
            TextBox loginTextBox = form.Controls.Find("loginTextBox", true).FirstOrDefault() as TextBox;
            TextBox passwordTextBox = form.Controls.Find("passwordTextBox", true).FirstOrDefault() as TextBox;
            TextBox confirmTextBox = form.Controls.Find("confirmTextBox", true).FirstOrDefault() as TextBox;

            if (thirdComboBox.SelectedItem == null)
            {
                MessageBox.Show("Введіть усі необхідні дані!");
                return false;
            }


            string[] regInfo =
            {
                surnameTextBox.Text.Trim(),
                nameTextBox.Text.Trim(),
                patronymicTextBox.Text.Trim(),
                ukrTextBox.Text.Trim(),
                mathTextBox.Text.Trim(),
                thirdComboBox.SelectedItem.ToString(),
                thirdTextBox.Text.Trim(),
                loginTextBox.Text.Trim(),
                passwordTextBox.Text.Trim(),
                confirmTextBox.Text.Trim()
            };

            foreach (string info in regInfo)
            {
                if (info == "" || info == null)
                {
                    MessageBox.Show("Введіть усі необхідні дані!");
                    return false;
                }
            }

            if (!int.TryParse(regInfo[3], out ukrGrade) || ukrGrade < 100 || ukrGrade > 200)
            {
                MessageBox.Show("Оцінки з НМТ повинні бути в межах від 100 до 200!");
                return false;
            }

            if (!int.TryParse(regInfo[4], out mathGrade) || mathGrade < 100 || mathGrade > 200)
            {
                MessageBox.Show("Оцінки з НМТ повинні бути в межах від 100 до 200!");
                return false;
            }

            if (!int.TryParse(regInfo[6], out thirdSubjectGrade) || thirdSubjectGrade < 100 || thirdSubjectGrade > 200)
            {
                MessageBox.Show("Оцінки з НМТ повинні бути в межах від 100 до 200!");
                return false;
            }

            if (regInfo[8] != regInfo[9])
            {
                MessageBox.Show("Паролі не співпадають. Спробуйте ще раз.");
                return false;
            }

            if (applicantsList.Applicants.Any(a => a.Login == regInfo[7]))
            {
                MessageBox.Show("Користувач з таким іменем вже існує. Виберіть інше ім'я.");
                return false;
            }

            Grades grades = new Grades
            {
                Ukrainian = int.Parse(regInfo[3]),
                Math = int.Parse(regInfo[4]),
            };

            switch (regInfo[5])
            {
                case "Іноземна мова":
                    grades.English = int.Parse(regInfo[6]);
                    break;
                case "Історія України":
                    grades.History = int.Parse(regInfo[6]);
                    break;
                case "Фізика":
                    grades.Physics = int.Parse(regInfo[6]);
                    break;
                case "Хімія":
                    grades.Chemistry = int.Parse(regInfo[6]);
                    break;
                case "Біологія":
                    grades.Biology = int.Parse(regInfo[6]);
                    break;
            }


            int newId = applicantsList.Applicants.Any() ? applicantsList.Applicants.Max(a => Int32.Parse(a.Id)) + 1 : 1;

            Applicant newApplicant = new Applicant
            {
                Id = newId.ToString(),
                Surname = regInfo[0],
                Name = regInfo[1],
                Patronymic = regInfo[2],
                Login = regInfo[7],
                Password = regInfo[8],
                Grades = grades
            };

            applicantsList.Applicants.Add(newApplicant);
            applicantsList.SaveToFile(applicantsList);

            MessageBox.Show("Реєстрація успішна!");
            ApplicantForm applicantForm = new ApplicantForm(form.GreetingForm, newApplicant.Login);
            applicantForm.Show();
            form.Close();

            return true;
        }
    }
}
