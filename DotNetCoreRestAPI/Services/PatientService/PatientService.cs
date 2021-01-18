using DotNetCoreRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreRestAPI.Services.PatientService
{
    public class PatientService : IPatientService
    {

        private static List<Patient> patients = new List<Patient>
        {
            new Patient(),
            new Patient{PatientID = 1},
            new Patient{PatientID = 2}
        };

        public Patient AddBodyTemperature(int patientID, Temperature bodyTemp)
        {
            Patient patient = patients.FirstOrDefault(x => x.PatientID == patientID);
            patient.TempData.Add(bodyTemp);
            return patient;
        }


        public List<Patient> AddPatient(Patient patient)
        {
            patients.Add(patient);
            return patients;
        }

        public Patient AddPersonalData(int patientID, PersonalData personalData)
        {
            Patient patient = patients.FirstOrDefault(x => x.PatientID == patientID);
            patient.personalData = personalData;
            return patient;
        }

        public PersonalData GetPersonalData(int patientID)
        {
            Patient patient = patients.FirstOrDefault(x => x.PatientID == patientID);
            return patient.personalData;
        }

        public Patient UpdatePersonalData(int patientID, PersonalData personalData)
        {
            Patient patient = patients.FirstOrDefault(x => x.PatientID == patientID);
            patient.personalData = personalData;
            return patient;
        }

        public List<Temperature> GetBodyTemperature(int patientID)
        {
            Patient patient = patients.FirstOrDefault(x => x.PatientID == patientID);
            return patient.TempData;
        }

    }
}
