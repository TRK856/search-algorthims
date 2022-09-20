// See https://aka.ms/new-console-template for more information
#nullable disable
Console.Clear();

int[] nums = new int[] { 10, 30, 40, 45, 70, 80, 85, 90, 100 };
string[] words = new string[] { "at", "ball", "cat", "dog", "eye", "fish", "good" };
int[] unsorted = new int[] { 30, 20, 70, 40, 50, 100, 90 };

// Search an array for an item using the linear search algorithm.
// If item found, return index where found, else return -1.
// int linear search
int intlinearSearch(int[] anArray, int item)
{
    for (int i = 0; i < anArray.Length; i++)
    {
        if (anArray[i] == item)
        {
            return i;
        }
    }

    // Went through for loop without finding item, so...
    return -1;
}

// string linear search
int stringlinearSearch(string[] anArray, string item)
{
    for (int i = 0; i < anArray.Length; i++)
    {
        if (anArray[i] == item)
        {
            return i;
        }
    }

    // Went through for loop without finding item, so...
    return -1;
}

// Search a SORTED array for an item using the binary search algorithm.
// If item found, return index where found, else return -1.
int intBinarySearch(int[] anArray, int item)
{
    int lowerIndex = 0;
    int upperIndex = anArray.Length - 1;

    while (upperIndex >= lowerIndex)
    {
        int middleIndex = (upperIndex + lowerIndex) / 2;
        if (anArray[middleIndex] == item)
        {
            return middleIndex;
        }
        else if (item < anArray[middleIndex])
        {
            upperIndex = middleIndex - 1;
        }
        else
        { // item > than the value at the middle index
            lowerIndex = middleIndex + 1;
        }
    }

    // Went through loop without finding item, so...
    return -1;
}

int stringBinarySearch(string[] anArray, string item)
{
    int lowerIndex = 0;
    int upperIndex = anArray.Length - 1;

    while (upperIndex >= lowerIndex)
    {
        int middleIndex = (upperIndex + lowerIndex) / 2;
        if (anArray[middleIndex] == item)
        {
            return middleIndex;
        }
        else if (-1 == String.Compare(item, anArray[middleIndex]))
        {
            upperIndex = middleIndex - 1;
        }
        else
        { // item > than the value at the middle index
            lowerIndex = middleIndex + 1;
        }
    }

    // Went through loop without finding item, so...
    return -1;
}

Console.WriteLine(intBinarySearch(nums, 100));
Console.WriteLine(intBinarySearch(nums, 75));
Console.WriteLine(stringBinarySearch(words, "fish"));
Console.WriteLine(stringBinarySearch(words, "at"));
Console.WriteLine(intBinarySearch(unsorted, 70));
