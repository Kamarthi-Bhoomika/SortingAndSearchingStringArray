using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSearchingStudentData
{
    internal class Program
    {
        //Sort Using BubbleSort
        public static void BubbleSort(string[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                string dir = "D:\\SortingSearchingStudentData\\SortingSearchingStudentData\\";
                string filename = dir + "StudentData.txt";

                if (File.Exists(filename))
                    Console.WriteLine("File exists");
                else
                    Console.WriteLine("File does not exist");

                Console.WriteLine("\nStudent Data: ");
                Console.WriteLine("Name\tClass");
                string[] lines = File.ReadAllLines(filename);
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }

                //Sorting using BubbleSort
                BubbleSort(lines);
                Console.WriteLine("\nAfter Sorting Student by name: ");
                Console.WriteLine("Name\tClass");
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }

                //Sorting using Array Operations
                /*Array.Sort(lines);
                Console.WriteLine("\nAfter Sorting Student by name: ");
                Console.WriteLine("Name\tClass");
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }*/
                Console.Write("\nEnter Student to search: ");
                string name = Console.ReadLine();

                //Searching using Array Operations
                string l = Array.Find(lines,s => s.StartsWith(name));
                if(l != null)
                {
                    Console.WriteLine("Student Found!!");
                    Console.WriteLine("Name\tClass");
                    Console.WriteLine(l);
                }
                else
                {
                    Console.WriteLine("Student not Found!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nEnd of Student Data");
                Console.ReadKey();
            }
        }
    }
}
