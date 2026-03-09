'' List<string> names = new List<string>() { "Olya", "Roma", "Sasha", "Dima", "Nazar" };


foreach (string name in names)
{
    try
    {
        Console.WriteLine("введіть id: ");

        string obj = Console.ReadLine();
        int index = int.Parse(obj);
        var id = names[index];

        Console.WriteLine($"знайдено: {id}");
        Console.WriteLine("-------");

    }
    catch (Exception ex)
    {
        Console.WriteLine("некоректний ввід");
    }
    
}

Console.ReadKey();

