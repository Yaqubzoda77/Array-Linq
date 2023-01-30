using System;
using System.Linq;
//task2
   int b;
   b = Convert.ToInt32(Console.ReadLine());
   int[] arr = new int[b];
   for (int i = 0; i < b; i++)
   {   
       arr[i] = Convert.ToInt32(Console.ReadLine());
   }
   var result = arr.Sum();
   System.Console.WriteLine(result);


//task3
 // List<double> data = new List<double>(){1000, 2000, 3000, 4000, 100, 350, 600, 800, 200, 300, 400};
 // double input = 420;
 // var FindCloset = data
 //       
 //    .Select(xs => new { n = xs, different = Math.Abs(xs - input) });
 // var result = FindCloset
 //    .Where(xs => xs.different == FindCloset.Select(y => y.different).Min()).First();
 // Console.WriteLine(result.n);






// Task4
// int[] array = new int[7] { 1, 3, 5, 2, 8, 6, 4 };
// var topThree = (from i in array 
//    orderby i 
//    select i).Take(3);
//
// foreach (var x in topThree)
// {
//    Console.WriteLine(x);
// }






//task5
// int x;
// x = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[x];
// for (int i = 0; i < x; i++)
// {   
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// var result = arr.Average();
// System.Console.WriteLine(result);



// Task 6
// int[] aray = new int[7] { 1, 3, 5, 2, 8, 6, 4 };
// var topThre = (from i in aray 
//    orderby i descending 
//    select i).Take(3);
//
// foreach (var x in topThre)
// {  
//    Console.WriteLine(x);
// }

// Task7
// int[] array = new int[7] { 1, 3, 5, 2, 8, 6, 4 };
// System.Console.WriteLine();
//
// System.Console.WriteLine("Square");
//
// var square = array.Select(x=> x*x);
// foreach (var item in square)
// {
//    System.Console.WriteLine(item);
// }


// Task8
// int[] array = new int[7] { 1, 3, 5, 2, 8, 6, 4 };
// System.Console.WriteLine("Cube");
//
// var cube = array.Select(x=> x*x*x);
// foreach (var item in cube)
// {
//    System.Console.WriteLine(item);
// }



// Task13
// int[] array = new int[7] { 1, 3, 5, 2, 8, 6, 4 };
// var oddsquare = array.Where(x => x % 2 != 0).Select(x=> x*x);
// foreach (var item in oddsquare)
// {
//    System.Console.WriteLine(item);
// }


// Task14
// int[] array = new int[7] { 1, 3, 5, 2, 8, 6, 4 };
// var squevenare = array.Where(x => x % 2 == 0).Select(x=> x*x);
// foreach (var item in squevenare)
// {
//    System.Console.WriteLine(item);
// }

// Task15
// int[] array = new int[7] { 1, 3, 5, 2, 8, 6, 4 };
// var oddCube = array.Where(x => x % 2 != 0).Select(x=> x*x*x);
// foreach (var item in oddCube)
// {
//    System.Console.WriteLine(item);
