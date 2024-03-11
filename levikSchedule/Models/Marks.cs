using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace levikSchedule.Models
{
    internal class Marks
    {
        [JsonPropertyName("math")]
        public int Математика { get; set; }

        [JsonPropertyName("bio")]
        public int Биология {  get; set; }

        [JsonPropertyName("practice")]
        public int Практика { get; set; }
    }
}
