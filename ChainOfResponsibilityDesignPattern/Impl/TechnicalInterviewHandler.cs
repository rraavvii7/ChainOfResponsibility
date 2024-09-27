namespace ChainOfResponsibilityDesignPattern.Impl;

using ChainOfResponsibilityDesignPattern.Interface;
using ChainOfResponsibilityDesignPattern.Models;

public class TechnicalInterviewHandler : IInterviewHandler
{
    public IInterviewHandler next { get; set; }
    public Candidate candidate { get; set; }
    public TechnicalInterviewHandler(Candidate candidate)
    {
        this.candidate = candidate;
    }
    public void Execute()
    {
        if(candidate.Technology == ".Net")
        {
            Console.WriteLine("Technical Round Passed");
        }
        else
        {
            candidate.IsQualifiedForNextRound = false;
            Console.WriteLine("Technical Round Failed");
        }
    }
    public void ExecuteAfter()
    {
        Console.WriteLine("Submitting technical round document for {0}", candidate.Name);
    }
}

