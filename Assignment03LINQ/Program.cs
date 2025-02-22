using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static Session03LINQ.ListGenerators;
using static System.Net.Mime.MediaTypeNames;
namespace Session03LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Partitioning Operators

            #region Q01 : Get the first 3 orders from customers in Washington

            //var Result = CustomerList.Where(C => C.City == "Washington").SelectMany(C => C.Orders).Take(3);

            //Result = (from C in CustomerList
            //          from O in C.Orders
            //          where C.City == "Washington" 
            //          select O).Take(3);



            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #region Q02 :Get all but the first 2 orders from customers in Washington.
            //var Result = CustomerList.Where(C => C.City == "Washington").SelectMany(C => C.Orders).Skip(2);

            //Result = (from C in CustomerList
            //          from O in C.Orders
            //          where C.City == "Washington"
            //          select O).Take(2);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Q03 :Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((N, I) => N > I);

            //foreach (var item in Result)
            //    Console.WriteLine(item);


            #endregion

            #region Q04 : Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //var Result = numbers.TakeWhile(N => N % 3 != 0) ;

            //foreach (var item in Result)
            //    Console.WriteLine(item);


            #endregion

            #region Q05 :  Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((Num,I)  => Num > I).Take(1);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion


            #region Grouping Operators


            #region Q01 : Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers.GroupBy(X => X % 5);

            //foreach ( var item in Result )
            //{

            //    Console.WriteLine($" Numbers with a remainder of {item.Key} when by 5 :  ");
            //    foreach (var num in item)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}



            #endregion

            #region Q02 : Uses group by to partition a list of words by their first letter.   Use dictionary_english.txt for Input
            //string file = "dictionary_english.txt";

            //string[] dictionary_english = File.ReadAllLines(file);

            //var Result = dictionary_english.GroupBy(X => X[0]);

            //foreach ( var item in Result)
            //{
            //    foreach (var item02 in item)
            //    {
            //        Console.WriteLine(item02);
            //    }
            //}




            #endregion

            #region Q03 : Consider this Array as an Input
            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            ////Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //var Result = Arr.GroupBy(A=> new string(A.OrderBy(B=>B).ToArray()));

            //foreach ( var item in Result) 
            //    {
            //       foreach ( var item2 in item)
            //       {
            //        Console.WriteLine(item2);
            //       }
            //    Console.WriteLine("..............");
            //    }


            #endregion
            #endregion


        }
    }
}
