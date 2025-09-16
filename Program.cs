static void PrintElements(string[] data)
{
    foreach (var item in data)
    {
        Console.WriteLine(item);
    }
}
PrintElements(new string[] { "bazinga", "jamal jenkins", "LEBROON" });
static int SumInts(int[] numbers)
{
    int sum = 0;
    foreach (var num in numbers)
    {
        sum += num;
    }
    return sum;
}
Console.WriteLine(SumInts(new int[] { 1, 2, 3, 4, 5 }));
static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;
    int boundary = (int)Math.Sqrt(number);
    for (int i = 3; i <= boundary; i += 2)
    {
        if (number % i == 0) return false;
    }
    return true;
    
}
Console.WriteLine(IsPrime(29));
static int BubbleSort(int[] numbers)
{
    int n = numbers.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
    return 0; // stops code crashing from no return error
}
Console.WriteLine(BubbleSort(new int[] { 64, 34, 25, 12, 22, 11, 90 }));int[] arr = new int[] { 64, 34, 25, 12, 22, 11, 90 };
BubbleSort(arr);
Console.WriteLine(string.Join(", ", arr));
static int IndexOf(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
            return i;
    }
    return -1;
}
// demonstrations
Console.WriteLine(IndexOf(new int[] { 10, 20, 30, 40 }, 30)); // Outputs: 2
Console.WriteLine(IndexOf(new int[] { 10, 20, 30, 40 }, 50)); // Outputs: -1


// Extension code: Binary Search
static int BinarySearch(int[] numbers, int target)
    {
    int left = 0;
    int right = numbers.Length - 1;
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (numbers[mid] == target)
            return mid;
        if (numbers[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }
    return -1;
}
// demonstration, assuming the array is sorted and 30 is the target.
Console.WriteLine(BinarySearch(new int[] { 10, 20, 30, 40, 50 }, 30)); // outputs: 2, as it is in the 3rd position (0-based index)