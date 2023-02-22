using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TextToJsonConverter.Model;

namespace TextToJsonConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(""/* Add link to csv file here*/);        
            List<Employees> employee = new();
            int count = 0;
            foreach (var item in lines)
            {
                var reader = item.Split(';');
                count++;
                if (count > 1)
                {
                    employee.Add(new Employees
                    {
                        FirstName = reader[0],
                        PreferredName = reader[1],
                        Surname = reader[2],
                        Age = reader[3],
                        ID = reader[4],
                        Ethnicity = reader[5],
                        Gender = reader[6],
                        PhoneNumber = reader[7],
                        Email = reader[8],
                        City = reader[9],
                        Province = reader[10],
                        Partner = reader[11],
                        AppFactory = reader[12],
                        StartedAssessment = reader[13],
                        AssessmentStatus = reader[14],
                        AssessmentScore = reader[15],
                        AssessmentDuration = reader[16],
                        RegDate = reader[17],
                        StartDate = reader[18],
                        EndDate = reader[19],
                        DurationOfInternship = reader[20],
                        Graduated = reader[21],
                        EmploymentStatus = reader[22],
                        Employer = reader[23]
                    });
                }
            }
            string results = JsonConvert.SerializeObject(employee);
            Console.WriteLine(results);
            File.AppendAllText(""/* Add save location here with file name with json extension*/, results);
        }
    }
}