
using ChainOfResponsibilityDesignPattern.Interface;
using ChainOfResponsibilityDesignPattern.Models;

namespace ChainOfResponsibilityDesignPattern.Impl
{
    public class ScreeningHandler : IInterviewHandler
    {
        public IInterviewHandler next { get; set; }
        public Candidate candidate { get; set; }
        public ScreeningHandler(Candidate candidate)
        {
            this.candidate = candidate;
        }

        public void Execute()
        {
            if(candidate.Stream == "B Tech")
            {
                Console.WriteLine("Screening Round Passed");
            }
            else
            {
                candidate.IsQualifiedForNextRound = false;
                Console.WriteLine("Screening Round Failed");
            }
        }

        public void ExecuteAfter()
        {
            Console.WriteLine("Submitting screening round document for {0}", candidate.Name);
        }
    }
}
