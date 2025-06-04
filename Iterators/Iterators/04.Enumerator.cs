using System.Collections;

namespace Iterators;

public class ArrayEnumerator(int[] arr) : IEnumerator<int>
{
    private int _index = 0;
        
    public int Current => arr[_index];

    public bool MoveNext() => ++_index < arr.Length;

    public void Reset() { }
    object? IEnumerator.Current => Current;
    public void Dispose() { }
}

public class TheEnumerator
{
    [Test]
    public void ArrayEnumeratorInAction()
    {
        var arrayEnumerator = new ArrayEnumerator([1, 56, 87]);
        do
        {
            Console.WriteLine(arrayEnumerator.Current);
        } while (arrayEnumerator.MoveNext());
    }


}