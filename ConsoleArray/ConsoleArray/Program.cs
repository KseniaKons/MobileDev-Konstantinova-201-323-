
//Массив (Array)

string[] cities = { "Тула", "Уфа", "Ялта", "Минск" };
Console.WriteLine(cities);
Console.WriteLine(cities[0]);
Console.WriteLine(cities[^1]); //первый с конца
Console.WriteLine($"Length = {cities.Length}");
Console.WriteLine();

//(1)
for (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]);

}
Console.WriteLine();

//(2)
foreach (var citi in cities)
{
        Console.WriteLine(citi);
}
Console.WriteLine();

//(3)
Console.WriteLine(String.Join<string>('\n', cities));
Console.WriteLine();

//Изменить размер массива
Array.Resize(ref cities, 3);
Console.WriteLine(String.Join<string>(' ', cities));
Console.WriteLine();


//Создать пустой массив 
string[] citiesNew1 = {};
string[] citiesNew2 = Array.Empty<string>();

//Копировать элементы массива 
Array.Resize<string>(ref citiesNew1, 10);
Array.Copy(cities, citiesNew1, 2);
Console.WriteLine(String.Join<string>(' ', citiesNew1));

//HW:
// - прочитать про индексы и диапазоны 
// - примеры вызовов других методов Array
