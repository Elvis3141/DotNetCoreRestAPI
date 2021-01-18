using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreRestAPI.Models
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int PatientID { get; set; }
        public List<Temperature> TempData { get; set; } = new List<Temperature>();
        public PersonalData personalData { get; set; } = new PersonalData();
    }
}
