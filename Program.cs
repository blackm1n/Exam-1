string[] array = {"hello", "hi", "bye", "marshmallow"};

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

Console.WriteLine(Count3orLess(array));