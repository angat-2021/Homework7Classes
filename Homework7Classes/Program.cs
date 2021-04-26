using System;

namespace Homework7Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var patient1=new Patient();
            patient1.FirstName="John";
            patient1.MidInitial = 'M';
            patient1.LastName = "Lewis";
            patient1.ID = 10;
            patient1.Weights.Add(DateTime.Now, 107.9);
            patient1.Weights.Add(DateTime.Now.AddDays(-30), 120.3);
            patient1.Weights.Add(DateTime.Now.AddDays(-60), 110.7);
            patient1.AppointmentHistory.Add("Covid Testing");
            patient1.AppointmentHistory.Add("flu");
            Console.WriteLine(patient1);
            patient1.AdministerVaccine();
            patient1.DisplayApptHist();
            Console.WriteLine(patient1);
            Console.WriteLine();

            var patient2 = new Patient();
            patient2.FirstName = "Roshan";
            patient2.MidInitial = 'N';
            patient2.LastName = "Rai";
            patient2.ID = 12;
            patient2.FluVaccineYN = false;
            patient2.Weights.Add(DateTime.Now, 106.7);
            patient2.Weights.Add(DateTime.Now.AddDays(-30), 120.6);
            patient2.Weights.Add(DateTime.Now.AddDays(-60), 115.8) ;
            patient2.AppointmentHistory.Add("Full body Checkup");
            patient2.AppointmentHistory.Add("Blood Test");
            Console.WriteLine(patient2);
            patient2.DisplayApptHist();
            patient2.AdministerVaccine();
            Console.WriteLine($"The max weight for this patient is " + patient2.CalculateMaxWeight() + " pounds.");

            Console.WriteLine();
            var patient3 = new Patient("Angat", 'N', "Yogi");
            patient3.ID = 13;
            patient3.FluVaccineYN = true;
            patient3.Weights.Add(DateTime.Now, 110.56);
            patient3.AppointmentHistory.Add("Physical Checkup");
            patient3.AppointmentHistory.Add("Follow up Checkup");
            Console.WriteLine(patient3) ;
            patient3.DisplayApptHist();
            patient3.AdministerVaccine();

            Console.WriteLine();

            var patient4 = new Patient(20);
            patient4.FirstName = "Sailen";
            patient4.MidInitial = 'N';
            patient4.LastName = "Yogi";
            patient4.FluVaccineYN = true;
            patient4.Weights.Add(DateTime.Now, 125.99);
            patient4.Weights.Add(DateTime.Now.AddDays(-90), 120.6);
            patient4.AppointmentHistory.Add("Full body Checkup");
            patient4.AppointmentHistory.Add("Blood Test");
            Console.WriteLine(patient4);
            patient4.DisplayApptHist();
            patient4.AdministerVaccine();
            Console.WriteLine($"The max weight for this patient is "+ patient4.CalculateMaxWeight()+" pounds.");
            Console.WriteLine();

            var patient5 = new Patient("Hugh", 'N', "Krikland");
            patient5.ID = 125;
            patient5.FluVaccineYN = false;
            patient5.Weights.Add(DateTime.Now.AddDays(-120), 190.45);
            patient5.Weights.Add(DateTime.Now, 200.7);
            patient5.AppointmentHistory.Add("Physical Checkup");
            patient5.AppointmentHistory.Add("Follow up Checkup");
            Console.WriteLine(patient5);
            patient5.DisplayApptHist();
            patient5.AdministerVaccine();
            Console.WriteLine($"The max weight for this patient is " + patient5.CalculateMaxWeight() + " pounds.");
            Console.WriteLine();

        }                               
    }                                   
}
