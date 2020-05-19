using System;
using System.Collections.Generic;

namespace Salary_Increase
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of lines");

            var lines = Convert.ToInt32(Console.ReadLine());

            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)

            {

                var cmdArgs = Console.ReadLine().Split();

                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

                persons.Add(person);

            }

            Console.WriteLine("enter bonus");

            var bonus = decimal.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(bonus));

            persons.ForEach(p => Console.WriteLine(p.ToString()));

            Console.ReadLine();

        }
    }
}
