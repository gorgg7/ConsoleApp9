using System;
using System.ComponentModel.Design.Serialization;
#region Q1

// public class duration
//{
//    public int hours { get; set; }
//    public int minutes { get; set; }
//    public int seconds { get; set; }

//    public duration(int hours = 0, int mintues = 0, int seconds = 0)
//    {
//        this.hours = hours;
//        this.minutes = mintues;
//        this.seconds = seconds;
//    }
//    public override string ToString()
//    {
//        return $"{hours} hours, {minutes} minutes, {seconds} seconds";
//    }
//    
//}
//class program
//{
//    static void Main(string[] args)
//    {
//        duration duration = new duration(12,6,50);
//        Console.WriteLine(duration);
//
//    }
//}
#endregion

#region Q3

//public class Duration
//{
//    public int Hours { get;  set; }
//    public int Minutes { get;  set; }
//    public int Seconds { get;  set; }

//    public Duration(int hours, int minutes, int seconds)
//    {
//        Hours = hours;
//        Minutes = minutes;
//        Seconds = seconds;
//    }

//    public Duration(int totalSeconds)
//    {
//        Hours = totalSeconds / 3600;
//        totalSeconds %= 3600;
//        Minutes = totalSeconds / 60;
//        Seconds = totalSeconds % 60;
//    }

//    public override string ToString()
//    {
//        return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Duration D1 = new Duration(1, 10, 15);
//        Console.WriteLine(D1); 

//        Duration D2 = new Duration(3600);
//        Console.WriteLine(D2); 

//        Duration D3 = new Duration(7800);
//        Console.WriteLine(D3); 

//        Duration D4 = new Duration(666);
//        Console.WriteLine(D4); 
//    }
//}
#endregion
#region Q4

public class Duration
{
    public int Minutes { get; set; }

    public Duration(int minutes)
    {
        Minutes = minutes;
    }
    public static Duration operator +(Duration d1, Duration d2)
    {
        return new Duration(d1.Minutes + d2.Minutes);
    }
    public static Duration operator +(Duration d, int minutes)
    {
        return new Duration(d.Minutes + minutes);
    }
    public static Duration operator +(int minutes, Duration d)
    {
        return new Duration(d.Minutes + minutes); 
    }
    public static Duration operator -(Duration d1, Duration d2)
    {
        return new Duration(d1.Minutes - d2.Minutes);
    }
    public static Duration operator ++(Duration d)
    {
        return new Duration(d.Minutes + 1);
    }
    public static Duration operator --(Duration d)
    {
        return new Duration(d.Minutes - 1);
    }
    public static bool operator >(Duration d1, Duration d2)//COUPLESSSS M3 3KSHA
    {
        return d1.Minutes > d2.Minutes;
    }
    public static bool operator <(Duration d1, Duration d2)
    {
        return d1.Minutes > d2.Minutes;
    }
    public static bool operator <=(Duration d1, Duration d2)//COUPLESSSS M3 3KSHA
    {
        return d1.Minutes <= d2.Minutes;
    }
    public static bool operator >=(Duration d1, Duration d2)
    {
        return d1.Minutes <= d2.Minutes;
    }
    public override string ToString()
    {
        return $"{Minutes} min";
    }
}
class Program
{
    static void Main()
    {
       Duration d1=new Duration(1);
       Duration d2=new Duration(2);
        Duration d3;
        d3=d1 + d2;
        Console.WriteLine(d3);
        d3 = d1 + 7800;
        Console.WriteLine(d3);
        d3 = 666 + d3;
        Console.WriteLine(d3);
        d3 = ++d1;
        Console.WriteLine(d3);
        d3 = --d1;
        Console.WriteLine(d3);
        d1 = d1 - d2;
        Console.WriteLine(d1);
        if (d1 > d2)
        {
            Console.WriteLine("d1 is greater");
        }
        else
        {
            Console.WriteLine("d2 is greater");
        }
        if (d1 <= d2)
        {
            Console.WriteLine("d2 is greater");
        }
        else
        {
            Console.WriteLine("d1 is greater");
        }
    }
}
#endregion
