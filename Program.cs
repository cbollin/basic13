using System;
using System.Collections.Generic;
namespace ConsoleApplication


{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Print 1-255

            // for(int i = 1; i<=255; i++){
            //     Console.WriteLine(i);
            // }

            // 2. Print odd numbers between 1-255

            // for(int i = 1; i<=255; i++){
            //     if( i % 2 != 0){
            //         Console.WriteLine(i);
            //     }
            // }

            // 3. Print Sum

            // int Sum = 0;
            // for( int i = 0; i <=255; i++){
            //     Sum += i;
            //     Console.WriteLine(i + " " + Sum);
            // }

            // 4. Iterating through an Array

            // int[] X;
            // X = new int [] {1,3,5,7,9,13};
            // for( int i = 0; i < X.Length; i++){
            //     Console.WriteLine(X[i]);
            // }

            // 5. Find Max

            // int Max = 0;
            // int[] Arr;
            // Arr = new int[] {1,99,3,4,5};
            // for(int i = 0; i < Arr.Length; i++){
            //     if(Arr[i] > Max){
            //         Max = Arr[i];
            //     }
            // }
            // Console.WriteLine(Max);

            // 6. Get Average

            // int Sum = 0;
            // int[] X;
            // X = new int [] {5,5,5,5,5};
            // for(int i = 0; i < X.Length; i++){
            //     Sum += X[i];
            // }
            // int Avg = Sum / X.Length;
            // Console.WriteLine(Avg);

            // 7. array with odd numbers & even

        // var evenArray = new int[10];
        // var oddArray = new int[128];

        // for (int i = 0, even = 0; i < evenArray.Length; i++, even += 2)
        // {
        //     evenArray[i] = even;
        // }

        // for (int i = 0, odd = 1; i < oddArray.Length; i++, odd += 2)
        // {
        //     oddArray[i] = odd;
        //     Console.WriteLine(oddArray[i]);
        // }
        
        // evenArray = [ 0, 2, 4, 6, 8, 10, 12, 14, 16, 18 ]
        // oddArray = [ 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 ]

            //greater than Y
        //     int[] array;
        //    array = new int[] {1,3,5,7,9,13};
        //    int y = 6;
        //    int count = 0;
        //    for(int i = 0; i < array.Length; i++) {
        //        if(array[i] > y) {
        //            count ++;
        //        }
        //    }
        //    Console.WriteLine(count);

            //square the Values
        //      int[] array;
        //    array = new int[] {1,3,5,7,9,13};
        //    for(int i = 0; i < array.Length; i++) {
        //        array[i] = array[i] * array[i];
        //        Console.WriteLine(array[i]);
        //    }
            
            // Eliminate Negative Numbers in Array
        //    int[] array;
        //    array = new int[] {1,-3,5,-7,9,-13};
        //    for(int i = 0; i < array.Length; i++) {
        //        if(array[i] < 0){
        //            array[i] = 0;
        //            Console.WriteLine(array[i]);
        //        }else{
        //            Console.WriteLine(array[i]);
        //        }
        //    }
        
           // Min, Max, Average of Array
        //    int[] array;
        //    array = new int[] {1,-3,5,-7,9,-13};
        //    int min = array[0];
        //    int max = array[0];
        //    int sum = 0;
        //    for(int i = 1; i < array.Length; i++) {
        //        if(min > array[i]) {
        //            min = array[i];
        //        }
        //        if(max < array[i]) {
        //            max = array[i];
        //        }
        //        sum = sum + i;
        //    }
        //    int avg = sum / array.Length;
        //    Console.WriteLine("Average: " + avg);
        //    Console.WriteLine("Min: " + min);
        //    Console.WriteLine("Max: " + max);
            
            // Shifting Values in Array
        //    int[] array;
        //    array = new int[] {1,-3,5,-7,9,-13};
        //    for(int i = 0; i < array.Length; i++) {
        //        array[i] = array[i + 1];
        //        Console.WriteLine(array[i]);
        //    }

           // Number To String 
        //    int[] array;
        //    array = new int[] {1,-3,5,-7,9,-13};
        //    for(int i = 0; i < array.Length; i++) {
        //        if(array[i] < 0){
        //            string myString = array[i].ToString();
        //            myString = "Dojo";
        //            Console.WriteLine(myString);
        //        }else{
        //            Console.WriteLine(array[i]);
        //        }
        //    }




            
        }
    }
}
