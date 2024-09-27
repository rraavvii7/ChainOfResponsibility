
using ChainOfResponsibilityDesignPattern.Models;

namespace ChainOfResponsibilityDesignPattern.Interface
{
    public interface IInterviewHandler
    {
        IInterviewHandler next { get; set; }
        Candidate candidate { get; set; }
        void Execute();
        void ExecuteAfter();
    }
}
