using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string input = "2302210449";
        DateTime result = ParseCustomDate(input);
        Console.WriteLine(result.ToString("yyyy-MM-dd HH:mm"));
    }

    public static DateTime ParseCustomDate(string input)
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < input.Length; i += 2)
        {
            string part = input.Substring(i, 2);
            numbers.Add(int.Parse(part));
        }

        int year = numbers[0] + 2000; // Considerando que o ano é 2000 + os dois dígitos fornecidos
        int month = numbers[1];
        int day = numbers[2];
        int hour = numbers[3];
        int minute = numbers[4];

        return new DateTime(year, month, day, hour, minute, 0);
    }
}
