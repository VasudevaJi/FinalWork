string[] ChooseLessThan3(string[] array)
{
    string[] result = new string[array.Length];
    var resultIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[resultIndex] = array[i];
            resultIndex++;
        }
    }
    return result;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input an array of strings separated by a space");
string? userString = Convert.ToString(Console.ReadLine());
string[] myArray = userString!.Split(' ');

string[] resArray = ChooseLessThan3(myArray);


ShowArray(resArray);
