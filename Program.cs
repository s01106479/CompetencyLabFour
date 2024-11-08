using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Add student name, course number, and CRN as a multi-line comment at the beginning of your code.
/* Isabella Tomasek
 * Course Number: 1050
 * CRN: 86411
 */

namespace CompetencyLabFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. In a comment, compare and contrast the if (single-selection) statement and while loop. How are the statements similar? How are they different?
            // Both the if statement and while loop look for conditions that are being met. An if statement only performs the operation once, whereas the while loop continues looping through as long as the specified condition is true.

            //3. Use a while loop to output values 48 to 92 on one line with one space between the values. Increment by 4. Note: 48 and 92 are inclusive.
            int i = 48;
            while (i <= 92)
            {
                Console.Write(i);
                if (i <= 92)
                {
                    Console.Write(" ");
                }
                i += 4;
            }

            Console.WriteLine();
            //Throwing in a line to separate the two problems in the console when the values are output.

            //4. Use a while loop to output values 98 to 21 on one line with one space between the values. Decrement by 7. Note: 98 and 21 are inclusive.
            int x = 98;
            while (x >= 21)
            {
                Console.Write(x);
                if (x >= 21)
                {
                    Console.Write(" ");
                }
                x -= 7;
            }

            Console.WriteLine();
            //Throwing in a line to separate the two problems in the console when the values are output.

            //5. Use a for loop to output values 61 to 72 on one line with one space between the values. Increment by 1. Note: 61 and 72 are inclusive.
            for (int t = 61; t <= 72; t++)
            {
                Console.Write(t);
                if (t <= 72)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
            //Throwing in a line to separate the two problems in the console when the values are output.

            //6.  Use a for loop to loop from 1-100. Each time through the loop, output the loop control variable and whether or not it is even or odd. Output on separate lines. Example: The output should be as follows (and so on):
            //1 is odd.
            //2 is even.
            // Here is code for checking to see if it's even or odd:
            // The condition (oddeven % 2 == 0) checks for even
            // You just need to wrap a for loop around this if statement
            for (int oddeven = 1; oddeven <= 100; oddeven++)
            {
                if (oddeven % 2 == 0)
                {

                    Console.WriteLine($"{oddeven} is even.");

                }

                else
                {

                    Console.WriteLine($"{oddeven} is odd.");

                }
            }

            //7. Use a while loop. Allow a user to input a value. Convert the input to an integer. If the input user enters equals 8, end the loop. Otherwise, keep asking for input.
            /*     A team member gives the following pseudocode:

                  - create int variable counter

                  - assign a value -7 to counter

                  - while (counter is not equal to 8)

                  - prompt user for input

                  - read input using Console.ReadLine()

                  - Convert it to an input using Convert.ToInt32()

                  - assign the value to counter

                  - output "Number entered " + counter  */
            int counter = -7;
            while (counter != 8)
            {
                Console.WriteLine("Please enter a number.");
                string input = Console.ReadLine();
                counter = Convert.ToInt32(input);
                Console.WriteLine("Number entered: " + counter);
            }

            //8. Use a for loop to output the sum of odd integers from 1 to 50.
            int sum = 0;
            for (int s = 1; s <= 50; s += 2)
            {
                sum += s;
            }
            Console.WriteLine(sum);

            //9. Use a while loop to output the following – 5 rows with 10 asterisks on each line.
            /*
            **********

            **********

            **********

            **********

            **********
            */
            int lineCount = 0;
            while (lineCount < 5)
            {
                int starCount = 0;
                while (starCount < 10)
                {
                    Console.Write("*");
                    starCount++;
                }
                Console.WriteLine();
                lineCount++;
            }
        }
    }
}
