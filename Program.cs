string[] array = { "Hello", "2522", "world", ":-)," };

int res = 3;
int length = CheckLength(array, res);
string[] newArray = CreateArray(length, res, array);
printArray(newArray);

int CheckLength(string[] arr, int lenLetters)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= lenLetters)
        {
            count += 1;
        }
    }
    return count;
}

string[] CreateArray(int lenArray, int lenLetters, string[] arr)
{
    string[] newArr = new string[lenArray];
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= lenLetters)
        {
            newArr[cnt] = arr[i];
            cnt += 1;
        }
    }
    return newArr;
}

void printArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i];
        Console.Write($"'{arr[i]}' ");
    }
    Console.Write("]");
}
