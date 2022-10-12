string[] a = new string[] { "hello", "2", "world", ":-)" };

string[] b = new string[] { "1234", "1567", "-2", "computer scince" };

string[] c = new string[] { "Russia", "Denmark", "Kazan" };


void PrintElMin3(string[] x)
{
    System.Console.WriteLine("Элементы массива длины которых меньше или равны трем: ");
    foreach (string i in x)
    {
        if (i.Length <= 3)
        {
            System.Console.Write(i + " ");
        }
    }
}

void PrintArray(string[] x)
{
    Console.WriteLine($"Массив: {string.Join(", ", x)}");
}

PrintArray(a);
PrintElMin3(a);
Console.WriteLine();
PrintArray(b);
PrintElMin3(b);
Console.WriteLine();
PrintArray(c);
PrintElMin3(c);