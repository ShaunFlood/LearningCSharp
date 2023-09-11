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
            Console.WriteLine("The current time is {0}", currentTime);
        }
    }
}