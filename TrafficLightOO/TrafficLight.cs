namespace TrafficLightOO
{
    internal class TrafficLight
    {
        private int _phase;

        public TrafficLight()
        {
            _phase = 0;
        }

        public void Show()
        {
            var isRedOn = _phase is 0 or 1;
            //var isRedOn = _phase <2
            var isYellowOn = _phase is 1 or 3;
            //var isYellowOn = _phase % 2 == 1
            var isGreenOn = _phase == 2;
            Console.WriteLine("┏━━━┓");
            MyConsole.WriteTrafficLightLine(isRedOn ? ConsoleColor.Red : ConsoleColor.Gray);
            MyConsole.WriteTrafficLightLine(isYellowOn ? ConsoleColor.Yellow : ConsoleColor.Gray);
            MyConsole.WriteTrafficLightLine(isGreenOn ? ConsoleColor.Green : ConsoleColor.Gray);
            Console.WriteLine("┗━━━┛");
        }

        public void Next()
        {
            if (_phase == 3) _phase = 0;
            else _phase++;

            // _phase = _phase == 3 ? 0 : _phase + 1;

            // _phase = (_phase + 1) % 4;
        }
    }
}
