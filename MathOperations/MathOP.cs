using System;

namespace MathOperations
{
    public class MathOP
    {
        public static double[] FindTheRoot(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return new double[] { };
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { root1, root2 };
            }
        }
        public static double CalculatePercentage(double total, double percentage)
        {
            return (total * percentage) / 100;
        }

    }
}