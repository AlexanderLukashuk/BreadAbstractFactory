using System;
using BreadAbstractFactory.Interfaces;

namespace BreadAbstractFactory.Models
{
    public class Bun : IBun
    {
        public void Bake()
        {
            Console.WriteLine("Bread is baked");
        }
    }
}