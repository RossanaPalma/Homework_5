/// Chapter No. 11 - Homework5_Part_2
/// File Name: homework5.java
/// @author: Rossana Palma
/// Date:  September 27, 2021
///
/// Problem Statement: Write a program that will print out statistics for eight coin tosses. The user will 
/// input either an “h” for heads or a “t” for tails for the eight tosses and the program displays he total 
/// number and percentages of heads and tails. 
/// 
/// Overall Plan:
/// 1) Declare and initialize variables
/// 2) Prompt user for h or t
/// 3) 
/// 4) 
/// 5) 

using System;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables    
            int h = 0, t = 0, count =0;
            double headTotal=0, tailTotal=0;
            int toss=0;

            Console.WriteLine("Enter h for head or t for tail. When finish type -1:");
            
            while (toss != -1)
               {
               toss = int.Parse(Console.ReadLine());
                  if (toss == 0)
                     {
                        headTotal++; // 0:head
                     }
                  else
                    {
                        tailTotal++; //1:tail
                    }

               }
            
            //Convert value into double        
            h = Convert.ToDouble(headTotal) / 8 * 100;
            t = Convert.ToDouble(tailTotal) / 8 * 100;
            

            Console.WriteLine("Percent of heads:" + h);
            Console.WriteLine("Percent of tails:" + t);
            Console.WriteLine("Total of heads:" + headTotal);
            Console.WriteLine("Total of tails:" + tailTotal);

        }
    }
}
   
