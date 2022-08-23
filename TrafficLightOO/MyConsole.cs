namespace TrafficLightOO
{
    internal class MyConsole
    {
        public static void WriteTrafficLightLine(ConsoleColor color)
        {
            var currentColor = Console.ForegroundColor;
            Console.Write("┃ ");
            Console.ForegroundColor = color;
            Console.Write("●");
            Console.ForegroundColor = currentColor;
            Console.WriteLine(" ┃");
        }
    }
}
