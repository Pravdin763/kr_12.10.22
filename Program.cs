string[] a = new string[] {"hello", "2", "world", ":-)"};

string[] b = new string[] {"1234", "1567", "-2", "computer scince"};

string[] c = new string[] {"Russia", "Denmark", "Kazan"};


void PrintElMin3(string[] x)
{
    foreach (string i in x)
    {
        if (i.Length <=3)
        {
            System.Console.Write(i+" ");
        }
    }
}


PrintElMin3(a);
Console.WriteLine();
PrintElMin3(b);
Console.WriteLine();
PrintElMin3(c);