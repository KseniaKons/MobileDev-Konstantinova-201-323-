Random rnd = new Random();

int floor = 1;
int wall = 1;
int x = 1;
int y = 1;
int z = 1;
Console.Write("Введите высоту: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину: ");
int width = Convert.ToInt32(Console.ReadLine());

int[,] cells = new int[height + 1, width + 1];

for (int j = 0; j < width * 2 + 1; j++)
{
    Console.Write("_");
}

for (int j = 0; j < width - 1; j++)
{
    cells[0, j]++;
}

Console.WriteLine();

for (int i = 0; i < height - 1; i++)
{

    y = rnd.Next(2);

    if (y == 1)
    {
        Console.Write("| ");
    }
    else
    {
        Console.Write("|_");
    }
    cells[i, 0]++;

    for (int j = 0; j < width - 1; j++)
    {
        floor = rnd.Next(2);
        wall = rnd.Next(2);
        x = rnd.Next(2);

        if (cells[i, j] == 2)
        {
            if (x == 1)
            {
                if (floor == 1)
                {
                    Console.Write("_ ");
                    cells[i + 1, j]++;
                }
                else
                {
                    Console.Write("  ");
                }

            }
            else
            {
                if (wall == 1)
                {
                    Console.Write(" |");
                    cells[i, j + 1]++;
                }
                else
                {
                    Console.Write("  ");
                }
            }
        }
        else
        {
            if (floor == 1)
            {
                Console.Write('_');
                cells[i + 1, j]++;
            }
            else
            {
                Console.Write(' ');
            }
            if (wall == 1)
            {
                Console.Write('|');
                cells[i, j + 1]++;
            }
            else
            {
                Console.Write(' ');
            }
        }
    }
    if (y == 1)
    {
        Console.Write(" |");
    }
    else
    {
        Console.Write("_|");
    }
    Console.WriteLine();
}

Console.Write("|_");
for (int i = 0; i < width - 1; i++)
{
    z = rnd.Next(2);
    if (z == 1)
    {
        Console.Write("__");
    }
    else
    {
        Console.Write("_|");
    }
}
Console.Write("_|");

Console.WriteLine();

Console.ReadLine();
