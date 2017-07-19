using System;
public class Program
{

    public static void Main()
    {
        ICar seat = new Seat("Leon", "Grey");
        ICar tesla = new Tesla("Model 3", "Red", 4);

        Console.WriteLine(seat.ToString());
        Console.WriteLine(tesla.ToString());
    }
}
