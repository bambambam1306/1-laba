


////////////////////////////////////////
//Дано список: { 1,2,3,1,4,5,2,2,1}
///Потрібно замінити повторювані числа 
//(якщо число повторюється більше ніж 1 раз) на 0 всередині масиву (1) (3)

List<int> newnumbers = new List<int>() { 1, 2, 3, 1, 4, 5, 2, 2, 1 };
//foreach(int a in newnumbers)
//    Console.WriteLine(a + " ");

var select = newnumbers.Select(number  => newnumbers.Count(x => x == number) > 1 ? 0 : number);

foreach(int z in select)
    Console.Write(z + " ");


Console.ReadKey();
