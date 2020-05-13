using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args )
        {
           
            
            char response = '0';                                                                                            

            do

            {
                Console.WriteLine("Please choose option");
                Console.WriteLine("1 - Add numbers one by one ");
                Console.WriteLine("2 - Empty ");                                                                           // choosing options
                Console.WriteLine("3 - Exit ");
                response = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (response)

                {
                    case '1':
                        {
                            Console.WriteLine("How much numbers contain in array?");
                            int size = Convert.ToInt32(Console.In.ReadLine());                                             // how much number will be sorted? 
                            int[] sort = new int[size];
                            

                            Console.WriteLine("Add numbers one by one using 'Enter'");

                            for (int i = 0; i < sort.Length; i++)
                            {
                                sort[i] = Convert.ToInt32(Console.ReadLine());
                            }
                                int zero = 0;
                                for (int a = 0; a < sort.Length; a++)
                                {
                                    for (int b = a + 1; b < sort.Length; b++)                                              // alghoritm of sorting
                                    {                                                   
                                        if (sort[a] > sort[b])
                                        {
                                            zero = sort[b];
                                            sort[b] = sort[a];
                                            sort[a] = zero;
                                        }

                                }
                                    Console.Write(sort[a] + " ");
                                }
                            Console.ReadKey();


                        }
                        break;
                        Console.Clear();


                    case '2':
                        Console.WriteLine("Functional in development stage");                                              //Work with files (load / save data - .txt files are good enough)
                      //  File.WriteAllLines("filename", sort.Select(i => i.ToString()).ToArray());
                        Console.ReadKey();
                        break;
                        Console.Clear();


                    case '3':
                        Console.WriteLine();
                        Console.WriteLine("Thanks for using our program. Bye Bye.");                        
                        Environment.Exit(0);
                        break;
                        Console.Clear();


                    default:
                        Console.WriteLine("Error - Selection does not match given options.");
                        break;
                }
            } while (response != '3');

            Console.ReadKey();
        }

    }
}