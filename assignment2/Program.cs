using System;
using System.Threading;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path= "C:\\Users\\QaweeySoetan\\Documents\\bidex\\.txt";

            int count = 0;
            List<string> list = new List<string>();

            for (int i = 0; i < 3; i++)
               
            {
                count++;
                Console.WriteLine("Please write activity at {0}", DateTime.Now );
                string topic = Console.ReadLine();
                Thread.Sleep(5000);
               
                list.Add(topic);


                




            }
            list.Reverse();
            File.AppendAllLines(path, list);
        }
    }
}
