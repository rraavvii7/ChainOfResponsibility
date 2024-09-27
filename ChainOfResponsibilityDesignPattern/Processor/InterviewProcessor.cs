
using ChainOfResponsibilityDesignPattern.Interface;

namespace ChainOfResponsibilityDesignPattern.Processor
{
    public class InterviewProcessor
    {
        private IInterviewHandler _rootHandler;
        private IInterviewHandler _currentHandler;

        public void RegisterHandlers(IInterviewHandler handler)
        {
            if(_rootHandler is null)
            {
                _rootHandler = handler;
                _currentHandler = handler;
            }
            else
            {
                _currentHandler.next = handler;
                _currentHandler = _currentHandler.next;
            }
        }

        public void Execute()
        {
            ProcessHandler(_rootHandler);
        }

        public void ProcessHandler(IInterviewHandler handler)
        {
            handler.Execute();
            if(handler.next is not null && handler.candidate.IsQualifiedForNextRound)
            {
                ProcessHandler(handler.next);
            }
            handler.ExecuteAfter();
        }
    }
}
