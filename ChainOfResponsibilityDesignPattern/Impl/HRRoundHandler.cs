using ChainOfResponsibilityDesignPattern.Interface;
using ChainOfResponsibilityDesignPattern.Models;

namespace ChainOfResponsibilityDesignPattern.Impl
{
    public class HRRoundHandler : IInterviewHandler
    {
        public IInterviewHandler next { get; set; }
        public Candidate candidate { get; set; }
        public HRRoundHandler(Candidate candidate)
        {
            this.candidate = candidate;
        }

        public void Execute()
        {
            if(candidate.SalaryExpectation >= 30 && candidate.SalaryExpectation <= 40)
            {
                Console.WriteLine("HR Round Passed");
            }
            else
            {
                candidate.IsQualifiedForNextRound = false;
                Console.WriteLine("HR Round Failed");
            }
        }

        public void ExecuteAfter()
        {
            Console.WriteLine("Submitting HR round documents for {0}", candidate.Name);
        }
    }
}
