
//Перечислимый тип (Enum)

class Program
{
    public enum SingleColor: byte {Red, Green=100, Blue}

    static void Main()
    {
        SingleColor singleColor;
        singleColor = SingleColor.Green;

        Console.WriteLine(singleColor);
        Console.WriteLine(singleColor.ToString("D"));
        Console.WriteLine(Enum.GetUnderlyingType(singleColor.GetType()));
    }

}




