using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Amazon";
        job1._startYear = 2015;
        job1._endYear = 2022;


        Job job2 = new Job();
        job2._jobTitle = "Product Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2025;


        Resume myResume = new Resume();
        myResume._name = "Joseph Moore";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        
        myResume.DisplayResume();
        



    }
}
