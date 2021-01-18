using DotNetCoreRestAPI.Models;
using DotNetCoreRestAPI.Services.PatientService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DotNetCoreRestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService patientService;

        public PatientController(IPatientService patientService)
        {
            this.patientService = patientService;
        }

        [HttpPost("temp/{id}")]
        public IActionResult AddBodyTemperature( int id, [FromBody] Temperature bodyTemp)
        {
            return Ok(patientService.AddBodyTemperature(id,bodyTemp));
        }

        [HttpPost]
        public IActionResult AddPatient(Patient patient)
        {     
            return Ok(patientService.AddPatient(patient));
        }

        [HttpPost("addpersonal/{id}")]
        public IActionResult AddPersonalData(int id, [FromBody] PersonalData personalData)
        {
            return Ok(patientService.AddPersonalData(id, personalData));
        }

        [HttpGet("data/{id}")]
        public IActionResult GetPersonalData(int id)
        {
            return Ok(patientService.GetPersonalData(id));
        }

        [HttpPut("personal/{id}")]
        public IActionResult UpdatePersonalData(int id, [FromBody] PersonalData personalData)
        {
            return Ok(patientService.UpdatePersonalData(id, personalData));
        }

        [HttpGet("temp/{id}")]
        public IActionResult GetBodyTemperature(int id)
        {
            return Ok(patientService.GetBodyTemperature(id));
        }

    }
}
