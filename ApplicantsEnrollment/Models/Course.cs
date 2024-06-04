using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursass.Models
{
    public class Course
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("budgetLimit")]
        public int BudgetLimit { get; set; }

        [JsonProperty("contractLimit")]
        public int ContractLimit { get; set; }

        [JsonProperty("isClosed")]
        public bool IsClosed { get; set; }

        [JsonProperty("isBudgeted")]
        public bool IsBudgeted { get; set; }

        [JsonProperty("isContracted")]
        public bool IsContracted { get; set; }

        [JsonProperty("isOrdered")]
        public bool IsOrdered { get; set; }

        [JsonProperty("coefficients")]
        public Coefficients Coefficients { get; set; }

        public Coefficients Coefficients1
        {
            get => default;
            set
            {
            }
        }
    }
}
