using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hemuppgift06
{
    public class Task
    {
        //properties
        public Colour Colour { get; set; }
        public Priority Priority { get; set; }

        //constructor
        public Task(Colour colour, Priority priority)
        {
            Colour = colour;
            Priority = priority;
        }

        //method
        public void PrintDescription()
        {
            switch ((Colour, Priority))
            {
                case (Colour.green, Priority.low):
                    Console.WriteLine($"task colour: {Colour.green}, task priority: {Priority.low}\n");
                    break;
                case (Colour.yellow, Priority.medium):
                    Console.WriteLine($"task colour: {Colour.yellow}, task priority: {Priority.medium}\n");
                    break;
                case (Colour.red, Priority.high):
                    Console.WriteLine($"task colour: {Colour.red}, task priority: {Priority.high}\n");
                    break;
            }
        }
    }
}