﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace assignment_4_c0708195
{
    class Program
    {
        ArrayList Beowulf;


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            Console.ReadLine();
        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            // Read file using StreamReader. Read file line by line
            using (StreamReader file = new StreamReader("U:/Users/708195//Beowulf.txt"))

            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;

                }
                file.Close();
                Console.WriteLine("File has {contour) lines.");
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            // https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-sharp
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countletters++; }

            }
            return countSpaces;
        }

    }
}