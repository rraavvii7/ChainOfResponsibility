
using ChainOfResponsibilityDesignPattern.Interface;
using ChainOfResponsibilityDesignPattern.Models;

namespace ChainOfResponsibilityDesignPattern.Impl
{
    public class ManagerialRoundHandler : IInterviewHandler
    {
        public IInterviewHandler next { get; set; }
        public Candidate candidate { get; set; }
        public ManagerialRoundHandler(Candidate candidate)
        {
            this.candidate = candidate;
        }

        public void Execute()
        {
            if((new List<string> { "Intermediate", "Advanced", "Expert" }).Contains(candidate.ExperienceLevel))
            {
                Console.WriteLine("Managerial Round Passed");
            }
            else
            {
               candidate.IsQualifiedForNextRound = false;
               Console.WriteLine("Managerial Round Failed");
            }
        }

        public void ExecuteAfter()
        {
            Console.WriteLine("Submitting managerial round documents for {0}", candidate.Name);
        }
    }
}
