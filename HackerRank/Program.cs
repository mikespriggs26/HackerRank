using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diaganol Difference
            //Calculate the difference of sums across the two diagonals of a square matrix
            //int n = 3;
            //int[][] x = new int[n][];

            //x[0] = new int[3] { 11, 2, 4 };
            //x[1] = new int[3] { 4, 5, 6 };
            //x[2] = new int[3] { 10, 8, -12 };

            //int result = 0;
            //int reverseResult = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    result += x[i][i];
            //}
            //int j = 0;
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    reverseResult += x[j][i];
            //    j++;
            //}

            //Console.WriteLine(result);
            //Console.WriteLine(reverseResult);
            //int difference = result - reverseResult;
            //Console.WriteLine(Math.Abs(difference));
            //Console.ReadKey();

            //*************************************************
            //Mini-Max Sum
            //Find the minimum and maximum values by summing four of five integers

            //int[] arr = new int[] { 1, 2, 3, 4, 5, };
            //int arrSum = arr[0] + arr[1] + arr[2] + arr[3] + arr[4];
            //int minSum = arrSum;
            //int maxSum = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int counter = 0;
            //    int testSum = arrSum - arr[counter];
            //    counter++;
            //    if (testSum > maxSum)
            //    {
            //        maxSum = testSum;
            //    }
            //    if(testSum < minSum)
            //    {
            //        minSum = testSum;
            //    }
            //    Console.WriteLine(testSum);

            //}
            //Console.WriteLine(minSum + " = minSum");
            //Console.WriteLine(maxSum + " = maxSum");
            //Console.ReadKey();

            //******************************************
            //Takes an array of ints, reverses the contents and puts in a new array
            //int counter = 0;
            //int[] arr = new int[] { 1, 2, 3, 4, };
            //int[] revArr = new int[4];
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    revArr[counter] = arr[i];
            //    counter++;
            //}
            //foreach (var item in revArr)
            //{
            //    Console.WriteLine(item);
            //}

            //*****************************************
            //Plus-minus
            //For a array, it will produce the percentage of +#s, -#s and zeros contained within

            //int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
            //float posCounter = 0;
            //float negCounter = 0;
            //float zeroCounter = 0;
            //foreach (var item in arr)
            //{
            //    if (item == 0)
            //    {
            //        zeroCounter += 1;
            //    }
            //    else if(item > 0)
            //    {
            //        posCounter += 1;
            //    }
            //    else if(item < 0)
            //    {
            //        negCounter += 1;
            //    }

            //}
            //Console.WriteLine(posCounter/arr.Length);
            //Console.WriteLine(zeroCounter/arr.Length);
            //Console.WriteLine(negCounter/arr.Length);

            //*************************************
            //Staircase
            //int n = 4;
            //for (int row = 0; row < n; row++)
            //{
            //    for (int i = 1; i < n - row; i++)
            //    {
            //        Console.Write(" ");

            //        //Console.WriteLine();
            //    }
            //    for (int column = n - row; column <= n; column++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //***********************************
            //Time Conversion - convert string to military time
            //string time = "11:05:45AM";
            //char a = time[0];
            //char b = time[1];
            //char c = time[8];   
            //char d = time[9];
            //string segment = time.Substring(2, 6);
            //string str = a.ToString() + b.ToString();
            //string ampm = c.ToString() + d.ToString();
            //int hours = int.Parse(str);

            //if (ampm == "PM")
            //{
            //    hours += 12;
            //}
            //if(ampm == "AM" && hours == 12)
            //{
            //    hours = 0;
            //}
            //string hour = hours.ToString();
            //string result = hour + segment;

            //Console.WriteLine(result);

            //Cats and a Mouse
            //int x = 1;
            //int y = 3;
            //int z = 2;
            //int catADiff = Math.Abs(x - z);
            //int catBDiff = Math.Abs(y - z);
            //if(catADiff > catBDiff)
            //{
            //    Console.WriteLine("Cat B");
            //}
            //else if(catADiff < catBDiff)
            //{
            //    Console.WriteLine("Cat A");
            //}
            //if(catADiff == catBDiff)
            //{
            //    Console.WriteLine("Mouse C");
            //}

            //The hurdle race
            //int[] height = new int[] { 1, 1, 3, 3, 2, };
            //int k = 4;
            //int maxHeight = 0;
            //for (int i = 0; i < height.Length - 1; i++)
            //{
            //    if(height[i] > maxHeight)
            //    {
            //        maxHeight = height[i];
            //    }
            //}
            //int heightDiff = maxHeight - k;
            //if(heightDiff <= 0)
            //{
            //    Console.WriteLine(0);
            //}
            //if(heightDiff > 0)
            //{
            //    Console.WriteLine(heightDiff);
            //}

            //Climbing the Leaderboard
            //int[] scores = new int[] { 100, 100, 50, 40, 40, 20, 10 };
            //int[] alice = new int[] { 5, 25, 50, 120 };

            //var uniqueScores = new List<int>();

            //var hashset = new HashSet<int>();
            //int counter = 1;
            //foreach (var item in scores)
            //{
            //    if (hashset.Add(item))
            //    {
            //        uniqueScores.Add(item);
               
            //    }
            //}
            
            //foreach (var item in alice)
            //{
            //    foreach (var score in uniqueScores)
            //    {
            //        if (score > item)
            //        {
            //            counter++;
            //        }

            //    }
            //    Console.WriteLine(counter);
            //    counter = 1;
            //}





            Console.ReadKey();
        }
    }
}
