using System;
using System.Collections.Generic;
using System.Linq;
public class Problem1
{
public static IEnumerable<int> myFilter(IEnumerable<int> input)
{
var filteredList = input.Where(x => x % 5 != 0 || x <= 50);
var cubedNumbers = filteredList.Select(x => x * x * x);
var result = cubedNumbers.Where(x => x % 2 != 0);
return result;
}
}
public class Problem2
{
public static IEnumerable<int> myFilter(IEnumerable<int> input)
{
var filteredList = input.Where(x => x % 6 != 0 || x >= 42);
var squaredNumbers = filteredList.Select(x => x * x);
var result = squaredNumbers.Where(x => x % 2 == 0);
return result;
}
}
public class TestProblem2
{
public static IEnumerable<int> merge(IEnumerable<int> input1,
IEnumerable<int> input2,
IEnumerable<int> input3,
IEnumerable<int> input4)
{
var groupedInputs =
input1.Concat(input2).Concat(input3).Concat(input4)
.GroupBy(x => x);
var result = groupedInputs
.Where(group => group.Count() == 4) // Present
// in all four lists
.Select(group => group.Key) // Select the
// common value
.Where(x => x % 10 == 0); // Filter multiples
// of 10
return result;
}
}
class Program
{
static void Main(string[] args)
{
Random rnd = new Random(5);
var listForProblem1 = Enumerable.Range(1, 100).Select(i =>
rnd.Next() % 101);
var listForProblem2 = Enumerable.Range(1, 100).Select(i =>
rnd.Next() % 101);
var list1 = Enumerable.Range(1, 15);
var list2 = Enumerable.Range(2, 42).Where(x => x % 2 == 0);
var list3 = Enumerable.Range(3, 21).Where(x => x % 2 != 0);
var list4 = Enumerable.Range(5, 21).Select(x => x * 5);
var answer1 = Problem1.myFilter(listForProblem1);
Console.WriteLine("Output for Problem1:");
foreach (int i in answer1)
{
Console.WriteLine(i);
}
Console.WriteLine("\n---------------\n");
var answer2 = Problem2.myFilter(listForProblem2);
Console.WriteLine("Output for Problem2:");
foreach (int i in answer2)
{
Console.WriteLine(i);
}
Console.WriteLine("\n---------------\n");
var answer3 = TestProblem2.merge(list1, list2, list3,
list4);
Console.WriteLine("Output for Problem3:");
foreach (int i in answer3)
{
Console.WriteLine(i);
}
}
}
