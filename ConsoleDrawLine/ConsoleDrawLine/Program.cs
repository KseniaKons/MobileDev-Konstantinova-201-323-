
bool isContinue = false;

do
{
    Console.WriteLine("Длинна?");

    //(1)
    //int width;
    //int.TryParse(Console.ReadLine(), out width);

    
    //(2)
    int.TryParse(Console.ReadLine(), out int width);

    Console.WriteLine(new String('*', width));


    Console.WriteLine("Повторить[Y/N]?");
    isContinue = (Console.ReadLine()?.ToUpper() == "Y");    
}while (isContinue);