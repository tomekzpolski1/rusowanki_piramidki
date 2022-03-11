using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wariant programu a/b/c/d:");
            string wariant = Console.ReadLine();
            switch (wariant)
            {
                case "a":
                    /*
                     **
                     ***
                     ****
                     */
                    Console.WriteLine("Wariant a");
                    Console.WriteLine("Wprowadź liczbę wierszy");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }

                    break;
                case "b":
                    /*
                     ****
                     ***
                     **
                     */
                    Console.WriteLine("Wariant b");
                    Console.WriteLine("Wprowadź liczbę wierszy");
                    int n2 = int.Parse(Console.ReadLine());
                    for (int i = n2; i > 0; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "c":
                    /*
                         * 
                        ** 
                       ***
                      ****
                    */
                    Console.WriteLine("Wprowadź liczbę wierszy");
                    int n3 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n3; i++)
                    {
                        for (int j = 1; j <= n3; j++)
                        {
                            if (j > (n3 - i))
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }

                    break;
                case "d":
                    /*
                     ***** 
                     *   *
                     *   *
                     *   *
                     *****
                     */
                    Console.WriteLine("Wariant d");
                    Console.WriteLine("Wprowadź liczbę wierszy");
                    int n4 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n4; i++)
                    {
                        for (int j = 1; j <= n4; j++)
                        {
                            if (i == 1 || i == n4 || j == 1 || j == n4)
                            { Console.Write("*"); }
                            else
                            { Console.Write(" "); }
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Koniec programu");
                    break;
            }
        }
    }
}
