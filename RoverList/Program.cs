using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> list = new RoverList<string>();
            list.Add("Hello");
            list.Add("there");
            list.Add("world");
            list.Add("my");
            list.Add("name");
            list.Add("is");
            list.Add("then");
            list.Add("where");
            list.Add("share");
            list.Add("want");
            list.Add("see");
            list.Add("are");
            list.Add("over");
            list.Add("project");
            list.Add("fair");
            list.Add("computer");
            list.ListNodes();

            Console.WriteLine("Input in some words and after you are done, type the word done!");

            while (true)
            {
                String line = Console.ReadLine();
                if (line == "done")
                    break;
                list.Add(line);
            }
            list.ListNodes();

            Console.WriteLine("Input in some words and after you are done, type the word done!");

            while (true)
            {
                String line = Console.ReadLine();
                if (line == "done")
                    break;
                list.Add(0, line);
            }



            list.ListNodes();


            Console.WriteLine("Now, lets remove all the words with an odd length, hit enter to continue");
            System.Console.ReadLine();

            int currentLength = list.wordNum();

            for (int i = currentLength - 1; i >= 0; i--)
            {

                string str = list.ElementAt(i);
                if (str.Length % 2 == 1)
                {
                    list.RemoveAt(i);
                }
            }
            list.ListNodes();

            Console.WriteLine("Now, lets clear the list. Hit enter to continue.");

            System.Console.ReadLine();

            list.Clear();



            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words

            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list
        }
    }
}
