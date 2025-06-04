namespace Iterators;

public class ThenOtherCollections
{
    [Test]
    public void Stacks()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(3);
        stack.Push(74);

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
    
    [Test]
    public void Queues()
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(3);
        queue.Enqueue(74);

        while (queue.TryPeek(out var _))
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}