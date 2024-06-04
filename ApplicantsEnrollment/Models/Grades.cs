using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursass.Models
{
    public class Grades
    {
        [JsonProperty("math")]
        public int Math { get; set; }

        [JsonProperty("ukrainian")]
        public int Ukrainian { get; set; }

        [JsonProperty("english")]
        public int English { get; set; }

        [JsonProperty("history")]
        public int History { get; set; }

        [JsonProperty("physics")]
        public int Physics { get; set; }

        [JsonProperty("chemistry")]
        public int Chemistry { get; set; }

        [JsonProperty("biology")]
        public int Biology { get; set; }
    }
}
