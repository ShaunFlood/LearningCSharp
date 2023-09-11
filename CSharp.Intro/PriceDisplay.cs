using System;

namespace CSharp.Intro
{
    class PriceDisplay
    {
        public void Display()
        {
           string item = "Coffee machine";
           double price = 15.99;
           Console.WriteLine("The price of the item {0} is {1:F2}", item, price);
        }
    } 
}