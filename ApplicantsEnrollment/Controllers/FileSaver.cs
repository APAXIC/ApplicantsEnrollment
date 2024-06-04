using Kursass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursass.Controllers
{
    internal class FileSaver
    {
        public static void GenerateInterviewList()
        {
            var applicationsList = new ApplicationsList();
            var coursesList = new CoursesList();
            var interviewApplications = applicationsList.Applications.Where(a => a.ApplicationStatus == "До співбесіди").ToList();

            if (!interviewApplications.Any())
            {
                MessageBox.Show("Немає заяв зі статусом 'До співбесіди'.");
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Списки для співбесід");
            sb.AppendLine();

            foreach (var course in coursesList.Courses)
            {
                var courseApplications = interviewApplications.Where(a => a.Destination == course.Code).ToList();

                if (courseApplications.Any())
                {
                    sb.AppendLine($"{course.Number}. {course.Name}");

                    int index = 1;
                    foreach (var app in courseApplications)
                    {
                        sb.AppendLine($"{index}. {app.Surname} {app.Name} {app.Patronymic}");
                        index++;

                    }

                    sb.AppendLine();
                }
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = "InterviewList.txt";
                saveFileDialog.Title = "Збереження файлу списків для співбесід";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, sb.ToString());
                    MessageBox.Show($"Списки для співбесід були збережені у файлі '{filePath}'.");
                }
            }
        }
    }
}
