using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("How many numbers would you like to randomize?");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = r.Next(1, 10);
            Console.WriteLine("Random Numbers: " + numbers[i]);
        }
        int added = Add(numbers);
        int mult = Multiply(numbers);
        Console.WriteLine("Numbers added total: " + added);
        Console.WriteLine("Numbers multiplied total: " + mult);
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}
