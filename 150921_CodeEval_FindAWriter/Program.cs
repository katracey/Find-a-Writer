using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150921_CodeEval_FindAWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Directions:
            You have a set of rows with names of famous writers encoded inside. 
            Each row is divided into 2 parts by pipe char (|). 
            The first part has a writer's name. The second part is a "key" to generate a name.

            Your goal is to go through each number in the key (numbers are separated by space) left-to-right. 
            Each number represents a position in the 1st part of a row. 
            This way you collect a writer's name which you have to output.
            */

            /*Sample code to read in test cases:
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
        }
    }
}*/

            string line = "osSE5Gu0Vi8WRq93UvkYZCjaOKeNJfTyH6tzDQbxFm4M1ndXIPh27wBA rLclpg| 3 35 27 62 51 27 46 57 26 10 46 63 57 45 15 43 53";

        
            //First split between index and letters
            string[] lineArray = line.Split('|');
            string name = lineArray[0];
            string index = lineArray[1];

            //Split index section into array
            char[] separator = new char[] { ' ' };
            string[] indexArray = index.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            //loop through with foreach loop to pull correct letter for each indexkey

            foreach (string indexKey in indexArray)
            {                
                System.Console.Write(name[(int.Parse(indexKey) - 1)]);
            }
            Console.WriteLine();
        

          
        }
    }
}
