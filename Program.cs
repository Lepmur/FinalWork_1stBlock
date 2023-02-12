string [] exampleFirst = {"hello","2","world",":-)"};
string [] exampleSecond = {"1234","1567","-2","computer science"};
string [] exampleThird = {"Russia","Denmark","Kazan"};

Console.WriteLine($"[{String.Join(", ",FilterArray(exampleFirst))}]");
Console.WriteLine($"[{String.Join(", ",FilterArray(exampleSecond))}]");
Console.WriteLine($"[{String.Join(", ",FilterArray(exampleThird))}]");

string [] FilterArray(string[] array)
{
    int tempCount = 0;
    foreach (var item in array)
    {
        if (item.Length <=3) tempCount++;
    }
    string[] result = new string[tempCount];
    tempCount = 0;
    foreach (var item in array)
    {
        if (item.Length <=3) result[tempCount++] = item;
    }
    return result;
}
