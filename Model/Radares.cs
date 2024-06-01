using Newtonsoft.Json;
using System.Collections.Generic;

namespace Model
{
    public class Radares
    {
        [JsonProperty("radar")] // Reflete a propriedade no JSON
        public List<Radar> registros { get; set; }
    }
}
