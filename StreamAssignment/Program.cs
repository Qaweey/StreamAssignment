using System;
using System.Collections.Generic;
using System.IO;

namespace StreamAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your file name");
           string name= Console.ReadLine();
            string path = "C:\\Users\\QaweeySoetan\\Documents\\bidex\\" + name  +".html"; 
             
            if (!File.Exists(path))
            {
                
                 Console.WriteLine("Please write the topic you want to talk about ");
             string topic=Console.ReadLine();
            File.AppendAllText(path, "<h1 style='text-align:center;background-color:blue' >" + topic + "<h1>");
            Console.WriteLine("How many paragraphs of content  do you want to write");
           int n =int.Parse(Console.ReadLine());


                

                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    count++;
                    Console.WriteLine("Paragraph"+count);
                string  content =  Console.ReadLine()  ;
                    string me = "<p style= 'font-size: 15px ; font-weight: normal; text-align: center'>" + content + "</p>";

                    var list = new List<string>() { me };
                    File.AppendAllLines(path, list);
                    


                }
               
                Console.WriteLine("Thank you");
                
            }
           ;
            

        }
    }
}
