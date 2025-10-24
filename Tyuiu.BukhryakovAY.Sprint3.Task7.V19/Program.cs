using Tyuiu.BukhryakovAY.Sprint3.Task7.V19.Lib;
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
        Console.WriteLine("Старт шага: " + StartValue);
        Console.WriteLine("Конец шага: " + StopValue);
        double[] res = dataService.GetMassFunction(StartValue, StopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("|    X     |    F(X)   |");
        Console.WriteLine("***************************************************************************");
        for(int i = 0; i < res.Length; i++)
        {
            int Xvalue = StartValue + i;
            Console.WriteLine("| {0,5:d}    | {1,8:f2}  |", Xvalue, res[i]);
        }
    }
}