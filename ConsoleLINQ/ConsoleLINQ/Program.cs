﻿
//пример 1
var arr0 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var arr = Enumerable.Range(0, 10).ToArray();

var myQuery =   //запрос
    from v in arr
    where v > 3 && v < 8
    orderby v descending
    select v;

Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(String.Join(" ", myQuery));
Console.WriteLine($"Count = {myQuery.Count()}, Sum = {myQuery.Sum()}");
Console.WriteLine( );

//Пример 2

var cities0 = new string[] { "Москва", "Тула", "Воронеж", "Смоленск", "Полтава"};
var cities1 = "Москва, Тула, Воронеж, Смоленск, Полтава".Split(", ");
Console.WriteLine(String.Join(" ", cities0));
Console.WriteLine(String.Join(" ", cities1));

var myQuery2 =
    from v in cities1
    where v.ToLower().EndsWith("а")
    select $"<{v.ToUpper()}>";

Console.WriteLine(String.Join(" ", myQuery2));

//Пример 3 LINQ метод расширения
var myQuery3 = cities1.Where(v => v.ToLower().EndsWith("а")).Select(v => $"<{v.ToUpper()}>");

Console.WriteLine(String.Join(" ", myQuery3));
Console.WriteLine();

var arr3 = cities1.Where(v => v.ToLower().EndsWith("а")).Select(v => $"<{v.ToUpper()}>").ToArray();

Console.WriteLine(String.Join(" ", arr3));
Console.WriteLine();

Console.WriteLine(String.Join("\n", arr3));
Console.WriteLine(String.Join(Environment.NewLine, arr3));
