using ChainOfResponsibilityDesignPattern.Impl;
using ChainOfResponsibilityDesignPattern.Models;
using ChainOfResponsibilityDesignPattern.Processor;

InterviewProcessor processor = new InterviewProcessor();
Candidate candidate = new Candidate
{
    Name = "Ravi",
    Technology = ".Net",
    ExperienceLevel = "Expert",
    IsQualifiedForNextRound = true,
    SalaryExpectation = 35,
    Stream = "B Tech"
};
processor.RegisterHandlers(new ScreeningHandler(candidate));
processor.RegisterHandlers(new TechnicalInterviewHandler(candidate));
processor.RegisterHandlers(new ManagerialRoundHandler(candidate));
processor.RegisterHandlers(new HRRoundHandler(candidate));

processor.Execute();
Console.ReadLine();