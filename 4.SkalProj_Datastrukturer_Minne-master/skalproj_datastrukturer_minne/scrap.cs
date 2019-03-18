using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class scrap
    {
        //var res1 = InterativeEven(n: 1);
        //var res2 = InterativeEven(n: 2);
        //var res3 = InterativeEven(n: 3);
        //var res4 = InterativeEven(n: 4);

        //var fib0 = InterativeFibonacci(0);   //0
        //var fib1 = InterativeFibonacci(1);   //1
        //var fib2 = InterativeFibonacci(2);   //1
        //var fib3 = InterativeFibonacci(3);   //2
        //var fib4 = InterativeFibonacci(4);   //3
        //var fib5 = InterativeFibonacci(5);   //5
        //var fib13 = InterativeFibonacci(13);

        //var fibo0 = InterativeFibonacci2(0);   //0
        //var fibo1 = InterativeFibonacci2(1);   //1
        //var fibo2 = InterativeFibonacci2(2);   //1
        //var fibo3 = InterativeFibonacci2(3);   //2
        //var fibo4 = InterativeFibonacci2(4);   //3
        //var fibo5 = InterativeFibonacci2(5);   //5
        //var fibo13 = InterativeFibonacci2(13);


        //static int InterativeFibonacci(int n)
        //{
        //    /*
        //    In the Fibonacci sequence of numbers, 
        //    each number is the sum of the previous two numbers. 
        //    Fibonacci began the sequence not with 0, 1, 1, 2, as modern mathematicians do 
        //    but with 1, 1, 2, etc. He carried the calculation up to the thirteenth place 
        //    (fourteenth in modern counting), that is 233, though another manuscript carries it to the next place: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
        //     */
        //    //0 1 1 2 3 5 8 13 21 34 55 89 144 233

        //    var fibonacciNumber = 0;
        //    var previousFibonacciNumber = 1;
        //    var nextFibonacciNumber = 0;

        //    for (int fibonacciSequenceNumber = 0; fibonacciSequenceNumber <= n; fibonacciSequenceNumber++)
        //    {
        //        if(fibonacciSequenceNumber == 0)
        //        {
        //            fibonacciNumber = fibonacciSequenceNumber;
        //        }
        //        else if(fibonacciSequenceNumber == 1)
        //        {
        //            previousFibonacciNumber = fibonacciNumber;
        //            fibonacciNumber = fibonacciSequenceNumber;
        //        }
        //        else
        //        {
        //            nextFibonacciNumber = fibonacciNumber + previousFibonacciNumber;
        //            previousFibonacciNumber = fibonacciNumber;
        //            fibonacciNumber = nextFibonacciNumber;
        //        }

        //        if (n == fibonacciSequenceNumber)
        //        {
        //            break;
        //        }
        //    }

        //    return fibonacciNumber;
        //}

        //static int InterativeFibonacci2(int n)
        //{
        //    /*
        //    In the Fibonacci sequence of numbers, 
        //    each number is the sum of the previous two numbers. 
        //    Fibonacci began the sequence not with 0, 1, 1, 2, as modern mathematicians do 
        //    but with 1, 1, 2, etc. He carried the calculation up to the thirteenth place 
        //    (fourteenth in modern counting), that is 233, though another manuscript carries it to the next place: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
        //     */
        //    //0 1 1 2 3 5 8 13 21 34 55 89 144 233
        //    var fibonacciNumber = 0;

        //    if (n == 0) return fibonacciNumber;
        //    if (n == 1) return ++fibonacciNumber;

        //    var previousFibonacciNumber = 0;
        //    var nextFibonacciNumber = 0;

        //    fibonacciNumber++;
        //    for (int fibonacciSequenceNumber = 2; fibonacciSequenceNumber <= n; fibonacciSequenceNumber++)
        //    {
        //        nextFibonacciNumber = fibonacciNumber + previousFibonacciNumber;
        //        previousFibonacciNumber = fibonacciNumber;
        //        fibonacciNumber = nextFibonacciNumber;

        //        if (n == fibonacciSequenceNumber)
        //        {
        //            break;
        //        }
        //    }

        //    return fibonacciNumber;
        //}

    }
}
