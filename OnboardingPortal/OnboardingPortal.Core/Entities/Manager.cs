using System;
using System.Collections.Generic;

namespace OnboardingPortal.Core.Entities
{
    public class Manager
    {
        public int IdManager { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }    
        public string Login { get; set;  }
        public string Password { get; set; }
        public string Sex { get; set; } //chage to enum later
        public string StatusOfEducation { get; set;  }
        public DateTime Hiringdate { get; set; }
        public string Location { get; set; }
        public float Salary { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Timereport> Timereports { get; set; }
        public ICollection<SupportCase> SupportCases { get; set; }
        public  ICollection<SupportMember> SupportMembers { get; set; }

    }
}