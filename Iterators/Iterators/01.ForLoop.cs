namespace Iterators;

public class ForLoop
{
    [Test]
    public void FirstThereWasTheForLoopOverArrays()
    {
        var arr = new[] { 1, 3, 74, 9124, -6 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    
    [Test]
    public void SometimesWithHandyNaming()
    {
        var arr = new[] { 1, 3, 74, 9124, -6 };
        for (int i = 0; i < arr.Length; i++)
        {
            var item = arr[i];
            Console.WriteLine(item);
        }
    }
}