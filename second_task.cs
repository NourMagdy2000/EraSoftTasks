// See https://aka.ms/new-console-template for more information
internal partial class Program
{
    private static void Main(string[] args)
    {
        // #task 1 grade checker
        //Console.WriteLine("Enter your mark (0-100):");
        //int grade=Convert.ToInt32(Console.ReadLine());

        //if (grade < 60) { Console.WriteLine("f"); }
        //else if (grade > 59 && grade< 70) { Console.WriteLine("d"); }
        //else if (grade > 69 && grade < 80) { Console.WriteLine("c"); }
        //else if (grade > 79 && grade < 90) { Console.WriteLine("b"); }
        //else { Console.WriteLine("a"); }


        // #task2 loops
        Console.WriteLine("Enter a number to print its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int i=1;
        while (i<=12) {
            Console.WriteLine($"{number}*{i}={number*i}");
            i++;
        }

    }
}