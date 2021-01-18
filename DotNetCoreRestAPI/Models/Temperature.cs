using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreRestAPI.Models
{
    public class Temperature
    {
        [Key]
        public int TempID { get; set; }
        public float BodyTemperature { get; set; } = 0;
        public DateTime MeasurementDate { get; set; } = DateTime.Now;

    }
}
