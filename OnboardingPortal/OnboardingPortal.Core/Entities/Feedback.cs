namespace OnboardingPortal.Core.Entities
{
    public class Feedback
    {
        public int IdFeedback { get; set; }
        public string Type { get; set; }//enum
        public string Scope { get; set; }
        
        public Employee Employee { get; set; }
    }
}