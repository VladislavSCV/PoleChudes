//class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public Company company { get; set; }

//    void person()
//    {
//        Console.WriteLine($"");
//    }
//}

//class Company
//{

//}


//Random rndm = new Random();
//int och= rndm.Next(10, 1000);
//Console.WriteLine(och);
//Console.WriteLine($"У вас {rndm} очков!");
string q;
Console.WriteLine("Введите букву:");
q = Console.ReadLine();

switch (q)
{
    case "U":
        Console.WriteLine("Ого");
        Thread.Sleep(2000);
        Random random1 = new Random();
        int p = random1.Next(10, 1000);
        Console.WriteLine(p);
        Console.WriteLine($"У вас {p} очков!");
        string w;
        Console.WriteLine("Введите букву:");
        q = Console.ReadLine();
        break;
    case "N":
        Console.WriteLine("Вау"); 
        Thread.Sleep(2000);
        Random random2 = new Random();
        int o = random2.Next(10, 1000);
        Console.WriteLine(o);
        Console.WriteLine($"У вас {o} очков!");
        string e;
        Console.WriteLine("Введите букву:");
        q = Console.ReadLine();
        break;
    case "I":
        Console.WriteLine("ХАХ");
        Thread.Sleep(2000);
        Random random3 = new Random();
        int i = random3.Next(10, 1000);
        Console.WriteLine(i);
        Console.WriteLine($"У вас {i} очков!");
        string r;
        Console.WriteLine("Введите букву:");
        q = Console.ReadLine();
        break;
    case "T":
        Console.WriteLine("Круто");
        Thread.Sleep(2000);
        Random random4 = new Random();
        int u = random4.Next(10, 1000);
        Console.WriteLine(u);
        Console.WriteLine($"У вас {u} очков!");
        string t;
        Console.WriteLine("Введите букву:");
        q = Console.ReadLine();
        break;
    case "y":
        Console.WriteLine("ДА");
        Thread.Sleep(2000);
        Random random5 = new Random();
        int l = random5.Next(10, 1000);
        Console.WriteLine(l);
        Console.WriteLine($"У вас {l} очков!");
        string y;
        Console.WriteLine("Введите букву:");
        q = Console.ReadLine();
        break;
    default:
        Console.WriteLine("Боюсь что вы не угадали букву. Попробуйте еще раз)");
        break;
        Console.WriteLine("Сумма ваших очков:");
        Console.WriteLine( p + o + i + u + l);

}
        


















