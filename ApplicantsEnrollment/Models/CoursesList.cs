using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursass.Models
{
    public class CoursesList : Course
    {
        public const string filePath = @"..\..\..\Data\courses.json";

        public List<Course> Courses { get; set; }

        public CoursesList()
        {
            this.Courses = new List<Course>();
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                List<Course> courses = JsonConvert.DeserializeObject<List<Course>>(jsonString);
                this.Courses = courses ?? new List<Course>();
            }
        }
    }
}
