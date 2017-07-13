using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wild_farm.Models;

namespace Wild_farm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalParams = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Animal animal = AnimalFactory.GetAnimal(animalParams);

                string[] foodParams = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Food food = FoodFactory.GetFood(foodParams);

                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine(animal);
            }

        }
    }
}

