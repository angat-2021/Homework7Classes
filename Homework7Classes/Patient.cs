using System;
using System.Collections.Generic;

namespace Homework7Classes
{
    public class Patient
    {
        public string FirstName { get; set; }
        public char MidInitial { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public bool FluVaccineYN { get; set; }
        public Dictionary<DateTime,double>  Weights { get; set; }
        public List<string> AppointmentHistory { get; set; }

        //constructors
        public Patient()
        {
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();
            FirstName          =string.Empty;
            MidInitial = '\0';
            LastName           =string.Empty;
            ID = 0;
            FluVaccineYN = false;
        }
        public Patient(int patID)
        {
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();
            FirstName = string.Empty;
            MidInitial = '\0';
            LastName = string.Empty;
            ID = patID;
            FluVaccineYN = false;
        }
        public Patient(string firstName,char midInit, string lastName)
        {
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();
            FirstName = firstName;
            MidInitial = midInit;
            LastName = lastName;
            ID = 0;
            FluVaccineYN = false;
        }

        //Methods
        public override string ToString()
        {
            if (FluVaccineYN==true)
            {
             return $"{LastName}, {FirstName} {MidInitial}.({ID}) Flu Vaccine: Yes" ;
            }
             return $"{LastName}, {FirstName} {MidInitial}.({ID}) Flu Vaccine: No";

        }

        public double CalculateMaxWeight()
        {
            double max = 0;
            foreach (double weight in Weights.Values)
            {
                if(weight > max)
                {
                    max = weight;
                }                    
            }
            return max;
        }

        public void DisplayApptHist()
        {
            Console.WriteLine($"Patient's past appointments:");
            
            foreach (var appt in AppointmentHistory)
            {
                Console.WriteLine("- "+appt);
            }
        }

        public void AdministerVaccine()
        {
            if (FluVaccineYN==true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Patient({ID}) has already been administered the vaccine.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Patient({ID}) has been administered the vaccine.");
                Console.ForegroundColor = ConsoleColor.White;
                FluVaccineYN = true;
            }
        }


    }
}
