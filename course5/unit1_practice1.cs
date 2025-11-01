using System;
using System.Collections.Generic;

public class Solution
{
    public static List<int> Solve(int[] arrayA, int[] arrayB)
    {
        
        Console.WriteLine("Array A = " + string.Join(",", arrayA));
        Console.WriteLine("Array B = " + string.Join(",", arrayB));
        
        // to make it clear: "position" is 1 based, "index" is 0 based
        
        // output holds the positions we visited in B. this is what we need to return
        List<int> output = new();
        
        // current position in A. this is where we start
        int positionA = 1;
        
        // we need to remember which positions we visited in array A
        // because the program should stop when a position in A is re-visited
        List<int> visited = new();
        
        // since we start at positions 1 in A, the first elemet of visited should be 1
        visited.Add(1);
        
        for (int i = 0; i < arrayA.Length; i++) {
            Console.WriteLine(); // empty line before each loop
            Console.Write($"Loop {i} | ");
            // get the value from A.  this is the position in B we want to "visit"
            int positionB = arrayA[positionA - 1]; 
            Console.Write($"positonA = {positionA} | positonB = {positionB} | ");
            
            // add visited B position to output
            output.Add(positionB);
            Console.Write("output = " + string.Join(",", output) + " | ");
            
            // visit B and get the position A
            positionA = arrayB[positionB - 1];
            Console.Write($"positionA = {positionA} | ");            
            
            Console.Write($"visited = " + string.Join(",", visited));
            
            // check if we've already visited the new position in A
            if (visited.Contains(positionA)) {
                Console.WriteLine(); // empty line
                Console.WriteLine("visited!!!");
                break;
            }
            
            visited.Add(positionA);
            
        }
        
        return output;
    }
}
