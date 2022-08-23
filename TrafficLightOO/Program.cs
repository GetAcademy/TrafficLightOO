using System.Text;
using TrafficLightOO;

Console.OutputEncoding = Encoding.UTF8;

var trafficLight = new TrafficLight();

while (true)
{
    Console.Clear();
    trafficLight.Show();
    trafficLight.Next();
    Console.ReadLine();
}

/*
    if (trafficLight._isRedOn)
    {
        Console.WriteLine("Stopp!");
    }

    trafficLight._isRedOn = false;
 */

/*
Versjon 2
Console.OutputEncoding = Encoding.UTF8;

var trafficLight = new TrafficLight();

while (true)
{
    Console.Clear();
    Console.WriteLine("┏━━━┓");
    MyConsole.WriteTrafficLightLine(trafficLight.isRedOn ? ConsoleColor.Red : ConsoleColor.Gray);
    MyConsole.WriteTrafficLightLine(trafficLight.isYellowOn ? ConsoleColor.Yellow : ConsoleColor.Gray);
    MyConsole.WriteTrafficLightLine(trafficLight.isGreenOn ? ConsoleColor.Green : ConsoleColor.Gray);
    Console.WriteLine("┗━━━┛");

    if (trafficLight.isRedOn && !trafficLight.isYellowOn && !trafficLight.isGreenOn)
    {
        trafficLight.isYellowOn = true;
    }
    else if (trafficLight.isRedOn && trafficLight.isYellowOn && !trafficLight.isGreenOn)
    {
        trafficLight.isRedOn = false;
        trafficLight.isYellowOn = false;
        trafficLight.isGreenOn = true;
    }
    else if (!trafficLight.isRedOn && !trafficLight.isYellowOn && trafficLight.isGreenOn)
    {
        trafficLight.isYellowOn = true;
        trafficLight.isGreenOn = false;
    }
    else if (!trafficLight.isRedOn && trafficLight.isYellowOn && !trafficLight.isGreenOn)
    {
        trafficLight.isYellowOn = false;
        trafficLight.isRedOn = true;
    }
    Console.ReadLine();

}
 */

/*
Versjon 1

Console.OutputEncoding = Encoding.UTF8;
var isRedOn = true;
var isYellowOn = false;
var isGreenOn = false;

while (true)
{
    Console.Clear();
    Console.WriteLine("┏━━━┓");
    MyConsole.WriteTrafficLightLine(isRedOn ? ConsoleColor.Red : ConsoleColor.Gray);
    MyConsole.WriteTrafficLightLine(isYellowOn ? ConsoleColor.Yellow : ConsoleColor.Gray);
    MyConsole.WriteTrafficLightLine(isGreenOn ? ConsoleColor.Green : ConsoleColor.Gray);
    Console.WriteLine("┗━━━┛");

    if (isRedOn && !isYellowOn && !isGreenOn)
    {
        isYellowOn = true;
    }
    else if (isRedOn && isYellowOn && !isGreenOn)
    {
        isRedOn = false;
        isYellowOn = false;
        isGreenOn = true;
    }
    else if (!isRedOn && !isYellowOn && isGreenOn)
    {
        isYellowOn = true;
        isGreenOn = false;
    }
    else if (!isRedOn && isYellowOn && !isGreenOn)
    {
        isYellowOn = false;
        isRedOn= true;
    }
    Console.ReadLine();

} 
 */