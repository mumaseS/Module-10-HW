class Calculator
{
    static ILogger Logger { get; set; }
    static void Main(string[] args)
    { 
        Logger = new Logger();
        Summary newSummary = new Summary(Logger); 

        var summ = new Summary(Logger);
        summ.Summ();
    }
}

public interface ILogger
{
    void Error(string message);
    void Event(string message);
}

public class Logger : ILogger
{
    void ILogger.Error(string message)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
    }

    void ILogger.Event(string message)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(message);
    }
}
public interface ISumm
{
    void Summ();
}

public class Summary : ISumm
{
    ILogger Logger { get; }
 

    public Summary(ILogger logger)
    {
        Logger = logger;
    }
    public void Summ()
    {
        Logger.Event("Калькулятор начал работу");
                               
        try
        {
            Console.WriteLine("Введите значение переменной а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine(c);

        }
        catch (OverflowException a) 
        {
            if (a is OverflowException) Logger.Error("Значение за границами диапазона");
            else Logger.Error("что-то случилось");
        }
        try { }
      
        catch (OverflowException b)
        {
            if (b is OverflowException) Logger.Error("Значение за границами диапазона");
            else Logger.Error("что-то случилось");
        }
        try { }
        
        catch (OverflowException c)
        {
            if (c is OverflowException) Logger.Error("Значение за границами диапазона");
            else Logger.Error("что-то случилось");
        }
        
        Logger.Event("Калькулятор закончил работу");

    }
}
