using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursass.Models
{
    public class ApplicantsList : Applicant
    {
        private const string filePath = @"..\..\..\Data\applicants.json";
        public List<Applicant> Applicants { get; set; }

        public ApplicantsList()
        {
            this.Applicants = new List<Applicant>();
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                List<Applicant> applicants = JsonConvert.DeserializeObject<List<Applicant>>(jsonString);
                this.Applicants = applicants ?? new List<Applicant>();
            }
        }

        public void SaveToFile(ApplicantsList applicantsList)
        {
            string json = JsonConvert.SerializeObject(applicantsList.Applicants, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
