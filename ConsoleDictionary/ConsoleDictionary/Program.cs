
//Словарь (Dictionary)
//ключ(id - уникальное значение) + значение 

Dictionary<int, string> x = new();
x.Add(10, "Калуга");
x.Add(55, "Псков");
x.Add(92, "Самара");
x.Add(13, "Брянск");

Console.WriteLine(x[92]);
x[55] = "Воронеж";
x[17] = "Курск";

foreach(var item in x)
{
    Console.WriteLine($"key = {item.Key}, value = {item.Value} ");
}