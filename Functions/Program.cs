using System;
using System.Net.Sockets;

namespace Functions
{
    class Program
    {
        private static float Add(float rhs, float lhs)
        {
            return rhs + lhs;
        }
        
        private static float Product(float rhs, float lhs)
        {
            return rhs * lhs;
        }

        private static float? Divide(float rhs, float lhs)
        {
            if (lhs == 0)
            {
                return null;
            }
            return rhs / lhs;
        }
        
        private static void Main(string[] args)
        {
            Console.WriteLine("Add function result: " + Add(3.0f, 3.0f));
            Console.WriteLine("Product function result: " + Product(3.0f, 3.0f));
            Console.WriteLine("Divide function result: " + Divide(3.0f, 0));
        }
    }
}