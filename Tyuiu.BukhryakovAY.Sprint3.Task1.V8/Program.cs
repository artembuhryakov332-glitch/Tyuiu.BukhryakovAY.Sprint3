
using Tyuiu.BukhryakovAY.Sprint3.Task1.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int StartValue = 1;
        int StopValue = 7;
        double value = 0.25;
        Console.WriteLine("Старт шага: " + StartValue);
        Console.WriteLine("Конец шага: " + StopValue);
        Console.WriteLine("Значение X: " + value);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = dataService.GetSumSeries(value, StartValue, StopValue);
        Console.WriteLine("Произведение ряда: " + res);
    }
}