
namespace ChainOfResponsibilityDesignPattern.Models
{
    public class Candidate
    {
        public string Name { get; set; }
        public string Stream { get; set; } //MCA BCA B.Tech Arts Commerce
        public string Technology { get; set; } //.net java python
        public string ExperienceLevel { get; set; } //Beginner Intermediate Expert
        public double SalaryExpectation { get; set; }
        public bool IsQualifiedForNextRound { get; set; }
        
    }
}
