using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Kursass.Models
{
    public class Users : Worker
    {
        private List<Worker> workers { get; set; }
        private List<Applicant> applicants { get; set; }

        public Users(string role)
        {
            this.workers = new List<Worker>();
            this.applicants = new List<Applicant>();
            FillWithUsersData(role);
        }

        private void FillWithUsersData(string role)
        {
            if (role == "worker")
            {
                string jsonString = File.ReadAllText(@"..\..\..\Data\workersInfo.json");
                List<Worker> workers = JsonConvert.DeserializeObject<List<Worker>>(jsonString);
                this.workers = workers;
            }
            else if (role == "applicant")
            {
                string jsonString = File.ReadAllText(@"..\..\..\Data\applicants.json");
                List<Applicant> applicants = JsonConvert.DeserializeObject<List<Applicant>>(jsonString);
                this.applicants = applicants;
            }
        }

        public bool Login(string login, string password, string role)
        {
            if (role == "worker")
            {
                foreach (var worker in workers)
                {
                    if (worker.Login == login.Trim())
                    {
                        if (worker.Password == password)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                foreach (var applicant in applicants)
                {
                    if (applicant.Login == login.Trim())
                    {
                        if (applicant.Password == password)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}
