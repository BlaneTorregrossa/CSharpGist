using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Gist 1: In C# create a new list of integers then populate the list with all
even numbers from 0 to 100. Then print all of these numbers to the console.
Once you have that loop through the list again and remove all numbers that are
a multiple of 10. Then print all the remaining numbers to the console.
 */

namespace CSharpGist
{




    class Program
    {


        static void Main(string[] args)
        {
            List<int> Gist = new List<int>();
            int i;
            for (i = 0; i < 101; i++)
            {
                if (i % 2 == 0 && i != 0)
                {
                    Gist.Add(i);
                }
            }

            for (i = 0; i < 101; i++)
            {

                Console.WriteLine(Gist[i]);        // No idea why Parentheses around i can't work instead of []

            }

            for (i = 0; i < 101; i++)
            {


                Gist.Remove(i);    // No idea why Parentheses around i can't work instead of []

            }

            for (i = 0; i < 101; i++)
            {

                Gist.Add(i);

            }

            for (i = 0; i < 101; i++)
            {
                if (i % 2 == 0 && i != 0 && i != 10)
                {
                    Console.WriteLine(Gist[i]);        // No idea why Parentheses around i can't work instead of []
                }
            }



        }


    }



}
