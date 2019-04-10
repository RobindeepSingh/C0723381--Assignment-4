using System;
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
            p.ReadTextFiles();
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
                string line;              
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("Sea") && line.Contains("Fare"))
                    {
                        counter++;
                    }
                    
                }

                file.Close();
            }
        }
        
        public int FindNumberOfBlankSpaces(string line)
        {
            int counterletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    counterletters++;

                }
                if (char.IsWhiteSpace(c))
                {
                    countSpaces++;
                }
            }
            return countSpaces;
        }
    }
   
}
