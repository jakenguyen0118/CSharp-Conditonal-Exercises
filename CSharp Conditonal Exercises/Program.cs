using System;

namespace CSharp_Conditonal_Exercises
{
    public static class Exercises
    {
        //1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.
        //Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        public static void One()
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            Console.WriteLine((number >= 1 && number <= 10) ? "valid" : "invalid");
        }

        //2- Write a program which takes two numbers from the console and displays the maximum of the two.
        public static void Two()
        {
            Console.WriteLine("Enter the first number");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((firstNumber > secondNumber) ? $"{firstNumber}{secondNumber}" : $"{secondNumber}{firstNumber}");
        }

        //3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
        public static void Three()
        {
            Console.WriteLine("Enter width size of image");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height size of image");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((width > height) ? "Your image is a landscape" : "Your image is a portrait");
        }

        //4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        //Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
        //If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points.
        //For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
        //If the number of demerit points is above 12, the program should display License Suspended.
        public static void Four()
        {
            Console.WriteLine("Enter your speed limit in km/h:");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed at which the car was driving:");
            var drivingSpeed = Convert.ToInt32(Console.ReadLine());

            if (drivingSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                var demeritPoints = (drivingSpeed - speedLimit) / 5;
                if(demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Driving received {0} demerit points for speeding.", demeritPoints);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises.One();
            //Exercises.Two();
            //Exercises.Three();
            //Exercises.Four();
        }
    }
}
