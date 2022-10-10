
//Очередь (Queue)

//(А) Обычная очередь (устаревший вариант)

using System.Collections;

Queue x = new();
x.Enqueue(6);
x.Enqueue(4);
x.Enqueue(5);
x.Enqueue(1);
x.Enqueue(11);
x.Enqueue("Hello");

Console.WriteLine($"Смотри -> {x.Peek()}");

while (x.Count > 0)
{
    Console.WriteLine(x.Dequeue());
}


//(В) Обобщенная очередь

Queue<int> numbers = new();

numbers.Enqueue(1);
numbers.Enqueue(3);
numbers.Enqueue(6);
numbers.Enqueue(77);
numbers.Enqueue(12);

Console.WriteLine();
Console.WriteLine($"Сумма = {numbers.Sum()}");
Console.WriteLine();

while(numbers.Count > 0)
{
    Console.WriteLine(numbers.Dequeue());
}