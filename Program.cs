/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Изначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.
["hello","2","world",":-)"] -> ["2",":-)"]
["1234","1567","-2","computer science"] -> ["-2"]
["Russia","Denmark","Kazan"] -> []
*/

string [] exampleFirst = {"hello","2","world",":-)"};
string [] exampleSecond = {"1234","1567","-2","computer science"};
string [] exampleThird = {"Russia","Denmark","Kazan"};

Console.WriteLine($"[{String.Join(", ",FilterArray(exampleFirst))}]");
Console.WriteLine($"[{String.Join(", ",FilterArray(exampleSecond))}]");
Console.WriteLine($"[{String.Join(", ",FilterArray(exampleThird))}]");


// можно было сделать проще конечно, тупо сразу вывести только те элементы массива которые меньше 4
// можно было в рамках метода не создавать новый массив, а сделать void, где поставить нужные элементы в начало
// а потом вывести только нужное количество по счетчику
// НО раз в задании написано сформировать новый массив... поэтому 2 цикла

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
