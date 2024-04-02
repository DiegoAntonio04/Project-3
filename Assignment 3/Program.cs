using System;

internal class Program
{
    static void Main(string [] args)
    {
    int sectomin= 60;
    int mintohr=60;
    int hrtoday=24;
    int daytomonth=30; //Average/Estimated 

    //
    System.Console.WriteLine("Enter Seconds: ");
    int seconds = int.Parse(System.Console.ReadLine());

    //Seconds to Minutes

    double minutes = seconds / (double)sectomin;
    Console.Write($"{seconds} seconds is equivalent to {minutes} minutes.");

    //Minutes to Hours
    double hours = minutes / mintohr;
    System.Console.Write($"{minutes} minutes is equivalent to {hours} hours");

    //Hours to Days
    double days = hours /hrtoday;
    System.Console.Write($"{hours}hours is equivalent to {days} days");

    //Days to Months
    double months= days/ daytomonth;
    System.Console.Write($"{days}days is equivalent to estimated {months} months");


    }
    

}


