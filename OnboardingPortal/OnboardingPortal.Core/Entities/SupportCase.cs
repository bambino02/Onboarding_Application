using System;

namespace OnboardingPortal.Core.Entities
{
    public class SupportCase
    {
        public int IdSupportCase { get; set; }
        public string Name { get; set;  }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        
        public int IdEmployee { get; set; }
        public int IdSupportMember { get; set; }
        public Employee Employee { get; set; }
        public Manager Manager { get; set; }
        public SupportMember SupportMember { get; set; }
    }
}