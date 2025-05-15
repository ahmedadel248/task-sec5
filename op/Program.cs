using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace op
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();   
            bool flag=false;
            while (!flag)
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");

                Console.Write("Enter your choice: ");
                char choice = Convert.ToChar(Console.ReadLine());

                switch (choice)
                {
                    case ('P' or 'p'):
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(" ", numbers)}]");
                        }
                        break;
                    case ('A' or 'a'):
                        Console.Write("Enter an integer number to add to list: ");
                       
                        string input = Console.ReadLine();
                        /** note 
                        try parse method in c#  to convert string representation of a number 
                        **/
                        if (int.TryParse(input, out int new_item))
                        {
                            numbers.Add(new_item);
                            Console.WriteLine($"{new_item} added");
                        }
                           break;

                    case('M' or 'm'):
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            int n = numbers.Count;
                            double sum = 0;
                            for (int i = 0; i < n; i++)
                            {
                                sum += numbers[i];
                            }
                            double mean = sum / n;
                            Console.WriteLine($"The mean is: {mean}");
                        }
                        break;
                    case ('S' or 's'):
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int smallest = numbers[0];
       
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] < smallest)
                                {
                                    smallest = numbers[i];
                                }
                            }
                            Console.WriteLine($"The smallest number is {smallest}");
                        }
                        break;
                    case ('L' or 'l'):
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = numbers[0];

                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] > largest)
                                {
                                    largest = numbers[i];
                                }
                            }
                            Console.WriteLine($"The largest number is {largest}");
                        }
                        break;
                    case ('Q' or 'q'):
                        Console.WriteLine("Goodbye");
                        flag = true;
                        break;
                }
            }
        }
    }
}
