﻿using System;

public class Program
{
  public  static void Main(string[] args)
    {
        try
        {
            string author = Console.ReadLine();
            string title = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());


            Book book = new Book(author, title, price);
            GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);

        }
    }
}
