using System;

namespace BodyMassIndexCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI();
            Console.ReadKey();

        }

        private static void BMI()
        {
            Console.WriteLine("Welcome to Body Mass Index Calculator :");
            Console.WriteLine("Please enter your height :");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your height is : " + height);
            Console.WriteLine("Please enter your weight :");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your weight is: " + weight);
            double bodyMassIndex = weight / (height * height);
            Console.WriteLine("Your Body Mass Index is :" + bodyMassIndex);
            if (bodyMassIndex < 16)
                Console.WriteLine("Severely underweight. Please consult a doctor. ");

            else if (bodyMassIndex >= 16 && bodyMassIndex < 17)
                Console.WriteLine(" Moderately underweight. Attention required. ");

            else if (bodyMassIndex >= 17 && bodyMassIndex < 18.5)
                Console.WriteLine(" Midly underwight. Monitor your diet. ");

            else if (bodyMassIndex >= 18.5 && bodyMassIndex < 25)
                Console.WriteLine(" Normal weight. Keep it up! ");

            else if (bodyMassIndex >= 25 && bodyMassIndex < 30)
                Console.WriteLine(" Overweight. Consider adjusting your lifestyle.");

            else if (bodyMassIndex >= 30 && bodyMassIndex < 35)
                Console.WriteLine("Obese Class I. Health risk increasing.");

            else if (bodyMassIndex >= 35 && bodyMassIndex < 40)
                Console.WriteLine("Obese Class II. High health risk.");

            else
                Console.WriteLine("Obese Class III. Serious health risk. Immediate action required.");
            {

            }
            {

            }
        }
    }
}