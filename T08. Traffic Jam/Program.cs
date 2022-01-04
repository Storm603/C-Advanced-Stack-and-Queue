using System;
using System.Collections.Generic;

namespace T08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPasingOnGreenCount = int.Parse(Console.ReadLine());

            string car = string.Empty;

            int crossedCars = 0;

            Queue<string> carsQueue = new Queue<string>();

            while ((car = Console.ReadLine()) != "end")
            {
                if (car == "green")
                {
                    for (int i = 0; i < carsPasingOnGreenCount; i++)
                    {
                        if (carsQueue.Count == 0)
                        {
                            break;
                        }
                        crossedCars++;
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        
                    }
                }
                else
                {
                    carsQueue.Enqueue(car);
                }
            }

            Console.WriteLine($"{crossedCars} cars passed the crossroads.");
        }
    }
}
