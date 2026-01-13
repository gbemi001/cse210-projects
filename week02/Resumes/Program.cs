using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Tech Corp";
        job1._startYear = 2020;
        job1._endYear = 2023;
        job1.DisplayJobDetails(job1._jobTitle, job1._company, job1._startYear, job1._endYear);

        Job job2 = new Job();
        job2._jobTitle = "AI Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2023;
        job2._endYear = 2025;
        job2.DisplayJobDetails(job2._jobTitle, job2._company, job2._startYear, job2._endYear);

        Resume myResume = new Resume();
        myResume._name = "Oluwagbemi Yoloye";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();
    }
}