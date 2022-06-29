using System;
using System.Collections.Generic;

namespace OnboardingPortal.Core.Entities
{
    public class Event
    {
        public int IdEvent { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime HeldDate { get; set; }
        public string Type { get; set; }//enum
        
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Manager> Managers { get; set; }
    }
}