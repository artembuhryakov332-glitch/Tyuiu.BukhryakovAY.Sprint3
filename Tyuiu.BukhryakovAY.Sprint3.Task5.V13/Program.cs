using Tyuiu.BukhryakovAY.Sprint3.Task5.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        **");
        Console.WriteLine("***************************************************************************");
        int x = 5;
        int StartValue1 = 1;
        int StopValue1 = 3;
        int StartValue2 = 1;
        int StopValue2 = 12;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = dataService.GetSumSumSeries(x, StartValue1, StartValue2, StopValue1, StopValue2); 
        Console.WriteLine("Произведение ряда: " + res);
    }
}