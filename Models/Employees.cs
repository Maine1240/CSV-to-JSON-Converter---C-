using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToJsonConverter.Model
{
    public class Employees
    {
        public string FirstName { get; set; }
        public string PreferredName { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string ID { get; set; }
        public string Ethnicity { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Partner { get; set; }
        public string AppFactory { get; set; }
        public string StartedAssessment { get; set; }
        public string AssessmentStatus { get; set; }
        public string AssessmentScore { get; set; }
        public string AssessmentDuration { get; set; }
        public string RegDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string DurationOfInternship { get; set; }
        public string Graduated { get; set; }
        public string EmploymentStatus { get; set; }
        public string Employer { get; set; }
    }
}