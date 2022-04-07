using System;
using System.Collections.Generic;

namespace TransformMethod
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int> TransformationFunction = x => ++x;

            foreach (var num in TransformationFunction.Transform())
                Console.WriteLine(num);
        }

        public static IEnumerable<int> Transform(this Func<int, int> Transformation)
        {
            for (int i = 0; i < 10; i++)
            {
                yield return Transformation(i);
            }

        }
    }
}
