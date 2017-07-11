using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Animal cat = new Cat("Pesho", "Whiskas");
        Animal dog = new Dog("Gosho", "Meat");
        
        Console.WriteLine(cat.ExplainMyself());
        Console.WriteLine(dog.ExplainMyself());
      
        var listOfAnimal = new List<Animal>();
        listOfAnimal.Add(cat);
        listOfAnimal.Add(dog);
     
        Print(listOfAnimal);
    }

    public static void Print(IEnumerable<Animal> Animals)
    {
        foreach (Animal animal in Animals)
        {
            Console.WriteLine(animal.ExplainMyself());

        }
    }
}

