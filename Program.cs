string[] arr = { "Hello", "2", "world", ":-)" };
string[] newArr = new string[2];


Console.Write("[ ");
for (int i = 0; i < newArr.Length; i++)
{
    newArr[i] = arr[i];
    Console.Write($"'{newArr[i]}' ");
}
Console.Write("]");
