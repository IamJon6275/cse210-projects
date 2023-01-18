using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Progrexion";
        job1._startYear = 2026;
        job1._endYear = 2068;

        Job job2 = new Job();
        job2._jobTitle = "Sales Tech";
        job2._company = "Progrexion";
        job2._startYear = 2023;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Jonathan Wells";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}