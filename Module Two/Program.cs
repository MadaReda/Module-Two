using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 8;j++ )
            { 
                for (int i = 0; i < 8; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
