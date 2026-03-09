using System.Collections.Generic;
using System.Text.Json;

Dictionary<int, string> names = new Dictionary<int, string>();


names.Add(1, "Olya");
names.Add(2, "Roma");
names.Add(3, "Sasha");
names.Add(4, "Olya");
names.Add(5, "Dima");
names.Add(6, "Nazar");
names.Add(7, "Roma");
names.Add(8, "Olya");


Dictionary<int, string> names1 = new Dictionary<int, string>();

List<string> namevalue = new List<string>();
foreach (var name in names)
{

    if (namevalue.Contains(name.Value) == false)
    {
        names1.Add(name.Key, name.Value);
        namevalue.Add(name.Value);

    }
}
foreach (var name1 in names1)
{
    Console.WriteLine(name1);
}

using (FileStream fs = new FileStream("newfile.json", FileMode.Create))
{

    await JsonSerializer.SerializeAsync(fs, names1);
}

