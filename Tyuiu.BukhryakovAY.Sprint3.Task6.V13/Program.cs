using Tyuiu.BukhryakovAY.Sprint3.Task6.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        **");
        Console.WriteLine("***************************************************************************");
        int StartValue = 8;
        int StopValue = 17;
        Console.WriteLine("Начало области определения: " + StartValue);
        Console.WriteLine("Конец области определения : " + StopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = dataService.GetSumTheDivisors(StartValue, StopValue);
        Console.WriteLine("Произведение ряда: " + res);
    }
}