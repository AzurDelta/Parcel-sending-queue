
Console.WriteLine(CalculateQueueTime([6, 3, 1], 1));
// вернет 10
Console.WriteLine(CalculateQueueTime([10, 2, 3, 3], 2));
// вернет 10
Console.WriteLine(CalculateQueueTime([2, 3, 10], 2));
// вернет 12

int CalculateQueueTime(int[] queue, int cashes)
{
    if (cashes == 1) return queue.Sum();

    var formedCashes = new int[cashes];
    foreach (var cart in queue)
    {
        formedCashes[Array.IndexOf(formedCashes, formedCashes.Min())] += cart;
    }

    return formedCashes.Max();
}