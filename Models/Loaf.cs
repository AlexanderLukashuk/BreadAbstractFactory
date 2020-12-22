using System;
using BreadAbstractFactory.Interfaces;

namespace BreadAbstractFactory.Models
{
    public class Loaf : ILoaf
    {
        public void Eat()
        {
            Console.WriteLine("Someone ate a loaf");
        }
    }
}