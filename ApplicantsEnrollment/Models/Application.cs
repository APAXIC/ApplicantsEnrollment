using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursass.Models
{
    public class Application
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("applicantId")]
        public string ApplicantId { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("patronymic")]
        public string Patronymic { get; set; }

        [JsonProperty("applicationStatus")]
        public string ApplicationStatus { get; set; }

        [JsonProperty("isConfirmed")]
        public bool IsConfirmed { get; set; }

        [JsonProperty("readyForContract")]
        public bool ReadyForContract { get; set; }

        [JsonProperty("canAffordContract")]
        public bool CanAffordContract { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("grades")]
        public Grades Grades { get; set; }

        [JsonIgnore]
        public Course Course { get; set; }

        public double AverageGrade
        {
            get
            {
                if (Course == null || Course.Coefficients == null) return 0.0;
                var coefficients = Course.Coefficients;
                double total = (Grades.Math * coefficients.Math + Grades.Ukrainian * coefficients.Ukrainian + Grades.English * coefficients.English +
                                Grades.History * coefficients.History + Grades.Physics * coefficients.Physics + Grades.Chemistry * coefficients.Chemistry +
                                Grades.Biology * coefficients.Biology);
                double sumOfCoefficients = coefficients.Math + coefficients.Ukrainian +
                                           ((Grades.English != 0) ? coefficients.English : 0) +
                                           ((Grades.History != 0) ? coefficients.History : 0) +
                                           ((Grades.Physics != 0) ? coefficients.Physics : 0) +
                                           ((Grades.Chemistry != 0) ? coefficients.Chemistry : 0) +
                                           ((Grades.Biology != 0) ? coefficients.Biology : 0);
                return sumOfCoefficients > 0 ? total / sumOfCoefficients : 0.0;
            }
        }

        public Applicant Applicant
        {
            get => default;
            set
            {
            }
        }

        public Course Course1
        {
            get => default;
            set
            {
            }
        }

        public Grades Grades1
        {
            get => default;
            set
            {
            }
        }
    }
}
