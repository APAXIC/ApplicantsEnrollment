using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursass.Models
{
    public class Coefficients
    {
        [JsonProperty("ukrainian")]
        public double Ukrainian { get; set; }

        [JsonProperty("math")]
        public double Math { get; set; }

        [JsonProperty("english")]
        public double English { get; set; }

        [JsonProperty("history")]
        public double History { get; set; }

        [JsonProperty("physics")]
        public double Physics { get; set; }

        [JsonProperty("chemistry")]
        public double Chemistry { get; set; }

        [JsonProperty("biology")]
        public double Biology { get; set; }
    }
}
