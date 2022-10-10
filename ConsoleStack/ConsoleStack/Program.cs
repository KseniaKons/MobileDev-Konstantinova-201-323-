
//Стек (Stack)

//(A) Обычный стек

using System.Collections;

Stack x = new();
x.Push("Рязань");
x.Push(100500);

Console.WriteLine($"Смотрим -> {x.Peek()}");
Console.WriteLine(x.Pop());
Console.WriteLine(x.Pop());

//(B) Обобщенный стек 

Stack<int> x1 = new();
x1.Push(1);
x1.Push(2);
x1.Push(3);
x1.Push(44);
x1.Push(55);

Console.WriteLine($"Смотрим -> {x1.Peek()}");
Console.WriteLine(x1.Pop());
Console.WriteLine(x1.Pop());
Console.WriteLine(x1.Pop());
Console.WriteLine(x1.Pop());
