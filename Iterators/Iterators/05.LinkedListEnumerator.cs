using System.Collections;

namespace Iterators;

public class AppliedToLinkedLists
{
    private class LinkedListEnumerator(Link link) : IEnumerator<int>
    {
        public int Current => link.Value;

        public bool MoveNext()
        {
            link = link.Next;
            return link != null;
        }

        public void Reset() { }
        object? IEnumerator.Current => Current;
        public void Dispose() { }
    }
    
    [Test]
    public void LinkedListEnumeratorInAction()
    {
        var arrayEnumerator = new LinkedListEnumerator(Link.ExampleList);
        do
        {
            Console.WriteLine(arrayEnumerator.Current);
        } while (arrayEnumerator.MoveNext());
    }
}