//Challenge is to use command line to display the current time.

// Define a new class and call from main method
// use Console.WriteLine.
// use DateTime Calss

using System;

namespace CSharp.Intro
{
    class CurrentTime
    {
        public void GetTime()
        {
            DateTime Time = DateTime.Now;
            string currentTime = Time.ToString("HH:mm");
            // this formats the DateTime function in to a string with format to only display the date and time.
            // {0} is the placeholder for the DateTime current time in the string, so it's included in the write line function.
            Console.WriteLine("The current time is {0}", currentTime);
        }
    }
}