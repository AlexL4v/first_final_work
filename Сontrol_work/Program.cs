string[] workArray = FillArray();
string[] resArray = NewArray(workArray);
string firstArray = PrintArray(workArray);
string secondArray = PrintArray(resArray);
Console.WriteLine(firstArray + " -> " + secondArray);

string[] FillArray()
{
    Console.WriteLine("Введите данные через пробел: ");
    string? Symbol = Console.ReadLine();
    if (Symbol == null) { Symbol =""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArray = Symbol.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}

string PrintArray(string[] workArray)
{
    string stringArray = "";
    for (int i = 0; i < workArray.Length; i++)
    {
        if (i == workArray.Length - 1)
        {
            stringArray += ($"\"{workArray[i]}\"");
            break;
        }
        stringArray += ($"\"{workArray[i]}\", ");
    }
    
    return stringArray;
}

int CountSymbol(string[] workArray)
{
    int count = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArray(string[] workArray)
{
    int resArrayLength = CountSymbol(workArray);
    string[] resArray = new string[resArrayLength];
    int i = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            resArray[i] = item;
            i++;
        }
    }
    return resArray;
}