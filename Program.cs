int Count3orLess(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count += 1;
    }
    return count;
}

string[] Arrayof3orLess(string[] array)
{
    string[] result = new string[Count3orLess(array)];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j += 1;
        }
    }
    return result;
}

Console.WriteLine("Введите слова через запятую.");
Console.WriteLine("Пример: hi, hello, bye");
string userinput = Console.ReadLine() ?? "0";

string[] input = userinput.Split(", ").ToArray();
string[] output = Arrayof3orLess(input);

for (int i = 0; i < output.Length; i++)
{
    Console.WriteLine($"{output[i]}");
}