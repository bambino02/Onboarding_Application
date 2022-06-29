using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace OnboardingPortal.Core.Entities
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }    
        public string Login { get; set;  }
        public string Password { get; set; }
        public string Sex { get; set; } //chage to enum later
        public string StatusOfEducation { get; set;  }
        public DateTime Hiringdate { get; set; }
        public string Location { get; set; }
        public float Salary { get; set; }
        
        public int IdManager { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<Event> Events { get; set; }
        public Manager Manager { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<Timereport> Timereports { get; set; }
        public ICollection<SupportCase> SupportCases { get; set; }


    }
    
}