using System.Collections.Generic;

namespace OnboardingPortal.Core.Entities
{
    public class Timereport
    {
        public int IdTimeReport { get; set; }
        public int WorkingDays { get; set; }
        public int VacationDays { get; set; }
        public int SeekDayd { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Manager> Managers { get; set; }
    }
}