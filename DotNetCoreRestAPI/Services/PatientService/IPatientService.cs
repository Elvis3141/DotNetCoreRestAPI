using DotNetCoreRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreRestAPI.Services.PatientService
{
    public interface IPatientService
    {
        List<Patient> AddPatient(Patient patient);
        PersonalData GetPersonalData(int patientID);
        Patient AddPersonalData(int patientID, PersonalData personalData);
        Patient UpdatePersonalData(int patientID, PersonalData personalData);
        Patient AddBodyTemperature(int patientID, Temperature bodyTemp);
        List<Temperature> GetBodyTemperature(int patientID);

    }
}
