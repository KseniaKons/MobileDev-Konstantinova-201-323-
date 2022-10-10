
//Список (list) 

//(A) обычный список (устаревший вариант)

using System.Collections;

ArrayList arrayList = new();
arrayList.Add(123);
arrayList.Add("Hello");
arrayList.Add(3.14);
//...

//(B) Обобщенный список (с приведением к конуретному типу)
List<string> cities = new() {"Москва", "Воронеж", "Севастопль"};
cities.Add("Pari");
cities.AddRange(new string[] { "Тула", "Архангельск" });
cities.RemoveAt(0);
cities.Reverse();

Console.WriteLine( string.Join(' ', cities));

cities.Sort(); //сортировка по алфавиту

Console.WriteLine( string.Join(' ', cities));