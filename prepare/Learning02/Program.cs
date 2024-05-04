using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first instance of Job class
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022; 

        // Create the second instance of job class
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create an instance of Resume class for Allison
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Adding the jobs created above to the jobs' list on the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.DisplayResumeDetails();
    }
}