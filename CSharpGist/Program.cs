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

            //static void Main(string[] args)
        //{
        //    List<int> Gist = new List<int>();
        //    int i;
        //    for (i = 0; i < 101; i++)
        //    {
        //        if (i % 2 == 0 && i != 0)
        //        {
        //            Gist.Add(i);
        //        }
        //    }

        //    for (i = 0; i < 101; i++)
        //    {

        //        Console.WriteLine(Gist[i]);        // No idea why Parentheses around i can't work instead of []

        //    }

        //    for (i = 0; i < 101; i++)
        //    {


        //        Gist.Remove(i);    

        //    }

        //    for (i = 0; i < 101; i++)
        //    {

        //        Gist.Add(i);

        //    }

        //    for (i = 0; i < 101; i++)
        //    {
        //        if (i % 2 == 0 && i != 0 && i != 10)
        //        {
        //            Console.WriteLine(Gist[i]);        // No idea why Parentheses around i can't work instead of []
        //        }
        //    }



        //}
 */



/*
Instruction:
Write a function that takes in as an argument a string representation of a binary number whose maximum amount is (2^8)-1.
This function must return a string matching this format except the first half should be the exact opposite of the second half.       
*/

namespace CSharpGist
{

    class Program
    {
        static public char Invert(char s)
        {
            return ((s == '0') ? '1' : '0');                                            // Replaces all '0' with '1'
        }

        public class Gene
        {
            public Gene(string s)
            {
                if (s.Length != 8)
                    throw new Exception("too big or too small... must be 8 long");
                value = s;                                                              // Assigns value to be the same as the argument
                tail = value.Substring(4);                                              
                head = value.Remove(4, 4);                                              
            }
            string value;
            string tail;
            string head;
            public override string ToString()
            {
                return value;
            }
            public string Head                                                          // Sets Head and head
            {
                get
                {
                    return head;
                }
            }

            public string Tail                                                         // Sets Tail and tail
            {
                get
                {
                    return tail;
                }
            }
        }


        static void Main(string[] args)
        {

            Gene g = new Gene("11111111");
            string temp = "";
            foreach (char i in g.Tail)
            {
                temp += Invert(i); 
            }
           
        }

    }



}
