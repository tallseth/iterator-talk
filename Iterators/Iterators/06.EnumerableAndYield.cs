using System.Collections;

namespace Iterators;

public class MyEnumerable : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        return new ArrayEnumerator([3, 6, 3, 234]);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class PlayWithYield
{
    public IEnumerable<int> YieldSomeInts()
    {
        var ints = new[] { 67, 123, 9870, 24324 };
        for (int i = 0; i < ints.Length; i++)
        {
            yield return ints[i];
        }
    }

    public IEnumerable<T> Repeat<T>(T valueToRepeat)
    {
        while (true)
        {
            yield return valueToRepeat;
        }
    }
    
    public IEnumerable<decimal> OddNumbers()
    {
        decimal counter = 1;
        while (true)
        {
            yield return counter++;
        }
    }
    
    public IEnumerable<string> FizzBuzz1()
    {
        Console.WriteLine("started");
        yield return "1";
        yield return "2";
        yield return "Fizz";
        Console.WriteLine("made an expensive API call");
        yield return "4";
        yield return "Buzz";
        foreach (var x in Repeat("not implemented yet").Take(100))
        {
            yield return x;
        }
    }
}