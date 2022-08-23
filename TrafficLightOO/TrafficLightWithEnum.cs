namespace TrafficLightOO
{
    internal class TrafficLightWithEnum
    {
        private TrafficLightPhase _phase;

        public TrafficLightWithEnum()
        {
            _phase = TrafficLightPhase.Red;
        }

        public void Show()
        {
            var isRedOn = _phase is TrafficLightPhase.Red or TrafficLightPhase.RedAndYellow;
            var isYellowOn = _phase is TrafficLightPhase.Yellow or TrafficLightPhase.RedAndYellow;
            var isGreenOn = _phase == TrafficLightPhase.Green;
            Console.WriteLine("┏━━━┓");
            MyConsole.WriteTrafficLightLine(isRedOn ? ConsoleColor.Red : ConsoleColor.Gray);
            MyConsole.WriteTrafficLightLine(isYellowOn ? ConsoleColor.Yellow : ConsoleColor.Gray);
            MyConsole.WriteTrafficLightLine(isGreenOn ? ConsoleColor.Green : ConsoleColor.Gray);
            Console.WriteLine("┗━━━┛");
        }

        public void Next()
        {
            if (_phase == TrafficLightPhase.Yellow) _phase = TrafficLightPhase.Red;
            else _phase++;
        }
    }
}
