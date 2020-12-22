using System;
using BreadAbstractFactory.Interfaces;

namespace BreadAbstractFactory.Models
{
    public class Flapjack : IFlapjack
    {
        public void Slice()
        {
            Console.WriteLine("Flapjack sliced");
        }
    }
}