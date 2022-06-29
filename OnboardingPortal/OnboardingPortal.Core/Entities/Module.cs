using System;
using System.Collections.Generic;

namespace OnboardingPortal.Core.Entities
{
    public class Module
    {
        
        public int IdModule { get; set; }
        public string Name { get; set; }
        public string Desctription { get; set; }
        public DateTime SubmitedDate { get; set; }
        public DateTime Deadlinedate { get; set; }
        public string Type { get; set;  }
        
        public ICollection<Employee> Employees { get; set; }
    }
}