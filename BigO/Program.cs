using System;
using System.Diagnostics;


string[] nemoCharacters = new string[]
{
    "Nemo",
    "Marlin",
    "Dory",
    "Gill",
    "Bloat",
    "Peach",
    "Gurgle",
    "Bubbles",
    "Deb",
    "Jacques",
    "Nigel",
    "Crush",
    "Squirt",
    "Bruce",
    "Anchor",
    "Chum"
};

#region Performance Using Time

// In C#, you can use classes from the System.Diagnostics namespace to create a stopwatch timer. It can be used to measure elapsed time with a high precision.

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

// Put logic that you want to measure here, 
findNemo(nemoCharacters);
stopwatch.Stop();

Console.WriteLine("Elapsed time: {0} seconds", stopwatch.Elapsed.TotalSeconds);

#endregion

Console.ReadKey();


#region Methods

void findNemo(string[] Array)
{
    foreach (var item in Array)
    {
        if (item.Equals("nemo"))
        {
            Console.WriteLine("Found Nemo");
        }
    }
}

#endregion

#region Explanation 

/*
   Big O notation is a mathematical notation that describes the limiting behavior of a function
   when the argument tends towards a particular value or infinity.
   In computer science, Big O notation is used to classify algorithms
   according to how their run time or space requirements grow as the input size increases.

   ! Here's a quick primer:

   * O(1): This is constant time complexity.
   It means the algorithm takes the same amount of time to execute regardless of the size of the input data set.
   An example would be an algorithm that accesses an array element directly.

   * O(n): This is linear time complexity.
   The execution time of the algorithm grows linearly with the size of the input data set.
   An example would be a loop that traverses an array.

   * O(log n): This is logarithmic time complexity.
   The execution time of the algorithm grows logarithmically with the size of the input data set.
   Binary search is an example of an algorithm which has logarithmic time complexity.

   * O(n^2): This is quadratic time complexity.
   The execution time of the algorithm is proportional to the square of the size of the input data set.
   Bubble sort, for example, has quadratic time complexity.
   It's important to note that Big O notation represents the worst-case scenario of an algorithm's time complexity.
   While it's a useful tool for analyzing and comparing algorithms, it doesn't provide a complete picture of an algorithm's performance in real-world use cases.
 */

#endregion