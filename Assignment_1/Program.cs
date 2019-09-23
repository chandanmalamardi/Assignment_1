using System;
using System.Collections.Generic;

namespace Assignment_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // initialization for self dividing numbers problem

            Console.WriteLine("\n Program : 1 \n");
            int num_1, num_2;
            Console.WriteLine("Enter the range below { number 1 , number 2 } \n ");
            Console.WriteLine(" Enter the number 1  \n ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the number 2  \n");
            num_2 = Convert.ToInt32(Console.ReadLine());
            printSelfDividingNumbers(num_1, num_2);

            /*
               Self-reflection  and Recommendation

              1. Learnt about extraction of digits from a number and catering the to serve our needs, 
                 also to use boolean functions in the programs.

              2. Would love to solve more programs which uses boolean functions.
              
             */

            // initialization for sequence problem

            Console.WriteLine("\n \n Program : 2 \n");
            int p2;
            Console.WriteLine("\n Enter the number to generate it's respective sequence ? \n ");
            p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ");
            printSeries(p2);

            /*
               Self-reflection  and Recommendation

              1. Learnt to manipulate loops to get desired sequences and enjoyed the logic.
              2. Learnt to use nested for loops that are usually the solutions to generate various patterns
              3. I would recommend that more number of such practice assignments that would enhance both our logical
                 thinking and the debugging.
              
             */

            // Initialization for Triangle series

            Console.WriteLine("\n \n \n Program : 3 \n");
            Console.WriteLine("\n \n How many lines of arrangement of stars do you wish to enjoy? \n");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ");
            printTriangle(num);

            /*
               Self-reflection  and Recommendation

              1. This was particularly bit hard to decode but was ecstatic when my logic finally worked.

              2. made use of nested for loops again in a different context and understood to manipulate 
                 the white space to get the desired patterns

              3. I would recommend to provide more complex patterns which involves a mixture of various patterns
               so that in one question we address various concepts and get familiar with.
              
             */

            // Initialization for Jewel Question

            Console.WriteLine("\n \n Program : 4 \n");
            int[] Jewels = new int[] { 1, 1, 2, 3, 4, 4, 5, 8, 9 };
            int[] Stones = new int[] { 2, 2, 3, 8, 8, 8, 7, 7, 9 };

            Console.WriteLine("\n The Jewels array contains following elements \n");
            for (int k = 0; k < Jewels.Length; k++)
                Console.WriteLine(Jewels[k] + "\n");

            Console.WriteLine("\n The Stones array contains following elements \n");
            for (int k = 0; k < Stones.Length; k++)
                Console.WriteLine(Stones[k] + "\n");

            Console.WriteLine("\n ");
            Console.WriteLine("\n Total number of stones amongst all the Jewels is \n");
            numJewelsInStones(Jewels, Stones);
            Console.WriteLine("\n ");

            /*
               Self-reflection  and Recommendation

              1. Learnt how arrays work and to get the subset values and also to traverse through them to
                 access each element.

              2. Would recommend you to provide assignments to work with dynamic arrays after introducing
                 them in class.
              
             */


            //Initialization for 5th one

            Console.WriteLine("\n \n Program : 5 \n");
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 5, 7, 8, 9, 10 };

            Console.WriteLine("\n The elements of array 1 elements are : ");
            for (int k = 0; k < arr1.Length; k++)
                Console.WriteLine(arr1[k] + "\n");

            Console.WriteLine("\n The elements of array 2 elements are : ");
            for (int k = 0; k < arr2.Length; k++)
                Console.WriteLine(arr2[k] + "\n");

            Console.WriteLine("\n ");
            int r5 = lcs(arr1, arr2);
            Console.ReadKey(true);

            /*
               Self-reflection  and Recommendation

              1. This was particularly a tricky one to solve. Learnt use of various string functions 
                 and convertion of array of integers to string of characters 

              2. I would recommend you to give problems like these in future because it had various 
                 concepts to be learnt to execute the program
              
             */



            // solvePuzzle();


        }



        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                /*
                    Here we create a list and store the numbers that are self divisible in the range provided by the
                    user. We iterate using a conditional loop (while loop) to check all the numbers starting from
                    the range provided by the user untill the upper bound number. To check wheather the number is 
                    divisible by all the digits making use of a boolean function SelfDividingNumberCheck() taking
                    each number as an input, each number is divided by 10 and the remainder is checked if it divides
                    the number itself and if true adding the respective number to the list created. Later the list 
                    contains all the self dividing numbers

                 */

                var Division_Check = new List<int>();
                int i = x;

                while (i <= y)
                {
                    if (SelfDividingNumberCheck(i))
                    {
                        Division_Check.Add(i);
                    }
                    i++;
                }

                int k = 0;

                while (k < Division_Check.Count)
                {
                    Console.WriteLine("\n" + Division_Check[k]);
                    k++;
                }

                bool SelfDividingNumberCheck(int s)
                {
                    int temp = s;
                    while (temp > 0)
                    {
                        int c = temp % 10;
                        if (c == 0 || s % c != 0)
                            return false;
                        temp = temp / 10;
                    }

                    return true;
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }


        private bool IsSelfDividingNumber(int n)
        {
            int temp = n;
            while (temp > 0)
            {
                int d = temp % 10;
                if (d == 0 || n % d != 0) return false;
                temp = temp / 10;
            }

            return true;
        }


        public static void printSeries(int n)
        {
            /*     
             Here the interger value provided as an input by the user is stored in variable n.
             Later we run nested loop to get the desored output. The first for() loop keeps track of the count 
             (runs n number of times). The second for loop here keeps track of the number of times the i value
             (if the  number is 3 : we print it thrice) is to be printed
             
             */

            try
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" " + i);
                    }
                }

            }
            catch
            {

                Console.WriteLine("Exception occured while computing printSeries()");

            }
        }

        public static void printTriangle(int n)
        {
            try
            {

                /*
                   We store and pass the input value(number of rows desired) provided by the user to variable n.
                   Later we run a for loop to print the leading spaces at the desired position. Another loop 
                   prints the respective stars providing spaces on both sides of the subsequent line and we print the 
                   stars required. This executes untill the first loop value drops less than zero.

                 */


                if (n < 0)
                    return;

                for (int a = n; a > 0; a--)
                {
                    for (int b = n; b > a; b--)
                    {
                        Console.Write(" ");
                    }
                    for (int c = 1; c < 2 * a; c++)
                    {
                        Console.Write("*");

                    }
                    Console.WriteLine();
                }

            }
            catch
            {

                Console.WriteLine("Exception occured while computing printTriangle()");
            }

        }
        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                /*
                    The values of jewels and Stones defined is stored in different arrays and then we compare
                    the two arrays to get the common elements and also to keep track of their count value. 
                    We run an outer loop which makes sure we address each value in an array and later the inner
                    loop matches each array elements in the Stones with the Jewels values that we have provided
                    a count variable keeping count for the number of stones that are present in the mixture of 
                    jewels and increments by value 1 everytime it encounters a stone in the jewel array. Latre we 
                    provide the count value as the number of stones presesnt in the Jewels.


                  */

                int count = 0;

                for (int i = 0; i < J.Length; i++)
                {
                    for (int j = 0; j < S.Length; j++)
                    {
                        if (J[i] == S[j])
                        {
                            count++;

                        }
                    }
                }

                Console.Write("\n" + count);

            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;

        }

        public static int lcs(int[] c, int[] d)
        {

            /* 
             
             Here two different arrays to be checked for largest common array is passed to this function and 
             firstly both the array contents are converted to string so the comparision becomes easy by the 
             use of inbuilt string functions. A two dimentional array variable is created which stores the largest 
             common array sequence. Nested loops are used to construct the logic. The outer for() loop traversing 
             through each value in the row of matrix and the inner for loop to cover all the elements in the 
             respective coloumn. Later we check if the values are equal in the respective matrix which hints
             about the subarrays presence, here the diagonal elements which are the largest subarray of elements 
             in any given matrix of arrays. We print the subarray obtained.
              
             */

            string a = string.Join("", c);
            string b = string.Join("", d);

            var len = new int[a.Length, b.Length];
            int greatestLength = 0;
            string output = "";
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        len[i, j] = i == 0 || j == 0 ? 1 : len[i - 1, j - 1] + 1;
                        if (len[i, j] > greatestLength)
                        {
                            greatestLength = len[i, j];
                            output = a.Substring(i - greatestLength + 1, greatestLength);
                        }
                    }
                    else
                    {
                        len[i, j] = 0;
                    }
                }
            }
            Console.WriteLine("The largest common sub array is as follows");
            Console.WriteLine("\n" + output);
            return 0;
        }


    }
}