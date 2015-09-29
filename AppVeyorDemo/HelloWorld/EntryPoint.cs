namespace HelloWorld
{
    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            var printer = new ConsolePrinter();
            printer.Print("Hello World");
        }
    }
}
