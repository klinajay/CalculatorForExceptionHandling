using CalculatorForExceptionHandling;

internal class Program
{
    private static void Main(string[] args)
    {
        AppDomain currentDomain = AppDomain.CurrentDomain;
        currentDomain.UnhandledException += new UnhandledExceptionEventHandler(Handler);
        Console.WriteLine("Hello, World!");
        Calculator calculator = new Calculator();
        calculator.TakeInput();
        
    }
    public static void Handler(object source , UnhandledExceptionEventArgs e)
    {
        Console.WriteLine("Sorry!!! something wen wrong inside calculator. Details: " + e.ExceptionObject);

    }
}