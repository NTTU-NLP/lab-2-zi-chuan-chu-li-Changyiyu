using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader sr = new StreamReader(@"D:\10311173\lab-2-zi-chuan-chu-li-Changyiyu\Data\Input.txt"))
            {
                while(sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach(var ch in line)
                    {     
                        if (Char.IsPunctuation(ch))
                        {
                           if(ch == '.')
                               Console.Write(ch + "\n");
                           else if (ch == '?')
                               Console.Write(ch + "\n");
                           else if (ch == '!')
                               Console.Write(ch + "\n");
                           else
                               Console.Write(ch);
                        }
                        else
                            Console.Write(ch);
                    }
                }
            }
            Console.Read();
        }
    }
}
