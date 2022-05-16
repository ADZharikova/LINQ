using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    internal class Hospital
    {
        private List<Patient> _patients = new List<Patient>();

        public void AddPatient(string firstName, string lastName, int age, string disease)
        {
            _patients.Add(new Patient(firstName, lastName, age, disease));
        }

        public void OrderByLastname()
        {
            var newHospitalByLastname = _patients.OrderBy(patient => patient.Lastname).ToList();

            foreach (var patient in newHospitalByLastname)
            {
                Console.WriteLine(patient.Lastname + " " + patient.Firstname + ", " + patient.Age + " лет.");
            }
        }

        public void OrderByAge()
        {
            var newHospitalByAge = _patients.OrderBy(patient => patient.Age).ToList();

            foreach (var patient in newHospitalByAge)
            {
                Console.WriteLine(patient.Lastname + " " + patient.Firstname + ", " + patient.Age + " лет.");
            }
        }

        public void FindWithDisease(string disease)
        {
            var newHospitalWithDisease = _patients.Where(patient => patient.Disease.ToLower() == disease.ToLower()).ToList();

            foreach (var patient in newHospitalWithDisease)
            {
                Console.WriteLine(patient.Lastname + patient.Firstname + ", " + patient.Disease);
            }
        }
    }
}
