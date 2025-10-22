using Tyuiu.BukhryakovAY.Sprint3.Task4.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        **");
        Console.WriteLine("***************************************************************************");
        int StartValue = -5;
        int StopValue = 5;
        Console.WriteLine("Начало области определения: " + StartValue);
        Console.WriteLine("Конец области определения : " + StopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = dataService.Calculate(StartValue, StopValue);
        Console.WriteLine("Произведение ряда: " + res);
    }
}