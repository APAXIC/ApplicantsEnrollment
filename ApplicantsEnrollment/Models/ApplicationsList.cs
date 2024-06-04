using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursass.Models
{
    public class ApplicationsList : Application
    {
        private const string filePath = @"..\..\..\Data\applications.json";
        private CoursesList coursesList;

        public List<Application> Applications { get; set; }

        public ApplicationsList()
        {
            this.coursesList = new CoursesList();
            this.Applications = new List<Application>();
            LoadFromFile();
            LinkApplicationsToCourses();
        }

        private void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                List<Application> applications = JsonConvert.DeserializeObject<List<Application>>(jsonString);
                this.Applications = applications ?? new List<Application>();
            }
        }

        private void LinkApplicationsToCourses()
        {
            foreach (var application in Applications)
            {
                application.Course = coursesList.Courses.FirstOrDefault(c => c.Code == application.Destination);
            }
        }

        public static void SaveApplicationToFile(Models.Application application)
        {
            string filePath = @"..\..\..\Data\applications.json";

            List<Application> allApplications;
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                allApplications = JsonConvert.DeserializeObject<List<Application>>(json);
            }
            else
            {
                allApplications = new List<Application>();
            }

            var existingApplication = allApplications.FirstOrDefault(a => a.Id == application.Id);
            if (existingApplication != null)
            {
                existingApplication.Surname = application.Surname;
                existingApplication.Name = application.Name;
                existingApplication.Patronymic = application.Patronymic;
                existingApplication.ApplicationStatus = application.ApplicationStatus;
                existingApplication.IsConfirmed = application.IsConfirmed;
                existingApplication.ReadyForContract = application.ReadyForContract;
                existingApplication.CanAffordContract = application.CanAffordContract;
            }

            string updatedJson = JsonConvert.SerializeObject(allApplications, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }
    }
}
