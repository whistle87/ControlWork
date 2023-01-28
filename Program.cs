//solutiuon
string inputLine = ReadData("Ввведите массив строк (строки разделяются запятой): ");
string[] stringArrayInput = SplitLineToStringArray(inputLine);
string[] stringArrayResult = StringArrayExtraction(stringArrayInput);
PrintArray(stringArrayResult);

// method create new array and add there string length of which is less than or equal to 3
string[] StringArrayExtraction(string[] inputArr)
{
    int num = 0;
    for (int i = 0; i < inputArr.Length; i++)
    {
        if(inputArr[i].Length<=3)
        {
            num++;
        }
    }
    string[] newArr = new string[num];
    num = 0;
    for (int i = 0; i < inputArr.Length; i++)
    {
        if(inputArr[i].Length<=3)
        {
            newArr[num] = inputArr[i];
            num++;
        }
    }
    return newArr;
}

//method create array of names from input string
string[] SplitLineToStringArray(string line)
{
    string[] stringArr = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
    return stringArr;
}
//method read data from console
string ReadData(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine()??"0";
    return line;
}
//method print array
void PrintArray (string[] array)
{
    Console.Write("[");
    for (int i=0;i<array.Length-1;i++)
    {
        Console.Write(array[i]+",");
    }
    Console.Write(array[array.Length-1]+"]");
}