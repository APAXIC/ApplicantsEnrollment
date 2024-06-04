using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursass.Models;
using Newtonsoft.Json;

namespace Kursass.Controllers
{
    internal class CourseCloser
    {
        public static void CloseCourse(string courseCode)
        {
            CoursesList coursesList = new CoursesList();
            var course = coursesList.Courses.FirstOrDefault(c => c.Code == courseCode);
            if (!course.IsClosed)
            {
                course.IsClosed = true;
                SaveCoursesToFile(coursesList);
                MessageBox.Show("Набір було закрито, дякую!");
            }
            else MessageBox.Show("Набір вже закрито!");
        }

        public static void SaveCoursesToFile(CoursesList coursesList)
        {
            string filePath = CoursesList.filePath;
            string json = JsonConvert.SerializeObject(coursesList.Courses, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
