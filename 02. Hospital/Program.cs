using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreatedPatient = 0;
            int countOfDoctors = 7;
            int currentPatients = 0;

            for (int day = 1; day <= period; day++)
            {
                
                if ((day % 3 == 0) && (untreatedPatient > treatedPatients)
                    {
                    countOfDoctors++;
                    }
                if (currentPatients > countOfDoctors)
                {
                    treatedPatients += countOfDoctors;
                    untreatedPatient += currentPatients + countOfDoctors;
                }
                else
                {
                    treatedPatients += currentPatients;
                    
                }
                
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatient}.");
        }

    }
}
