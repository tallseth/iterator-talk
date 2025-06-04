namespace Iterators;

public class ReallyJustLinkedLists
{
    [Test]
    public void LinkedList()
    {
        var linkedList = Link.ExampleList;
        var currentLink = linkedList;
        Console.WriteLine(linkedList.Value);
        while (currentLink.Next != null)
        {
            currentLink = currentLink.Next;
            Console.WriteLine(linkedList.Value);
        }
    }
}

public class Link
{
    public int Value;
    public Link? Next;
        
    public static Link ExampleList = new()
    {
        Value = 1,
        Next = new Link
        {
            Value = 3,
            Next = new Link
            {
                Value = 74,
                Next = null
            }
        }
    };
}