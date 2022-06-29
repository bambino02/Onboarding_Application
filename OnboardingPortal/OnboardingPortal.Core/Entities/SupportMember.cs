using System;
using System.Collections.Generic;

namespace OnboardingPortal.Core.Entities
{
    public class SupportMember
    {
        public int IdSupportmember { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HiringDate { get; set; }
        public float Salary { get; set; }
        
        
        public ICollection<SupportCase> SupportCases { get; set; }
        public Manager Manager { get; set; }

    }
}