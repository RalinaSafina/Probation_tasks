using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Parsing_csv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write path to the file: ");
            string FilePath = Console.ReadLine();
            if (File.Exists(FilePath))
            {
                Console.WriteLine("Write column to sort: ");
                int column_sort = Convert.ToInt32(Console.ReadLine());
                StreamReader file = new StreamReader(FilePath);
                string line;
                int col_number = 0;
                List<List<string>> write = new List<List<string>>();
                while ((line = file.ReadLine()) != null)
                {
                    string buffer_1 = "";
                    List<string> buffer_2 = new List<string>();
                    int i = 0, counter = 0, temp = 0;
                    while (i < line.Length)
                    {
                        if (line[i] == '"')
                        {
                            counter = (counter + 1) % 2;
                            i++;
                        }
                        else if (line[i] == ',' && counter == 0)
                        {
                            buffer_2.Add(buffer_1);
                            buffer_1 = "";
                            i++;
                            temp++;
                        }
                        else
                        {
                            buffer_1 += line[i];
                            i++;
                        }
                    }
                    buffer_2.Add(buffer_1);
                    write.Add(buffer_2);
                    if (temp + 1 >= col_number)
                        col_number = temp + 1;
                }
                if (column_sort > 0 && column_sort <= col_number)
                    sort(write, column_sort - 1);
                else
                {
                    Console.WriteLine("Incorrect number of column to sort. Try again!");
                    write.Clear();
                    Main(args);
                }
                for (int i = 0; i < write.Count(); i++)
                {
                    string str = "";
                    for (int j = 0; j < write[i].Count(); j++)
                        str += write[i][j] + "|";
                    Console.WriteLine(str);
                }
            }
            else
            {
                Console.WriteLine("This file doesn't exist. Try again!");
                Main(args);
            }
        }
        public static void sort(List<List<string>> array, int column)
        {
            array.Sort((a, b) => a[column].CompareTo(b[column]));
        }
    }
}
