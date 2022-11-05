
var colors = Enum.GetValues<ConsoleColor>();

foreach (var ColorText in colors)
{
    Console.ForegroundColor = ColorText;

    foreach (var backColor in colors)
    {
        Console.BackgroundColor = backColor;

        Console.Write("123");
    }

    Console.WriteLine();
}
Console.ResetColor();