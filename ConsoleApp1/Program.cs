﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
        }
        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader (@"U:\Users\723381\beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine())!= null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }

            }
        }
    }
   
}
