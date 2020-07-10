using System.Collections.Generic;

namespace Dorf.Engine
{
    public interface IWürfel
    {
        IReadOnlyList<int> VerfügbareWerte { get; }
        int Wuerfeln();
    }

    public sealed class SechserWürfel : IWürfel
    {
        private readonly IRandomizer _randomizer;
        private List<int> _werte = new List<int> { 1, 2, 3, 4, 5, 6 };

        public SechserWürfel(
            IRandomizer randomizer)
        {
            _randomizer = randomizer;
        }

        public IReadOnlyList<int> VerfügbareWerte => _werte.AsReadOnly();

        public int Wuerfeln() => VerfügbareWerte[_randomizer.Next(0, VerfügbareWerte.Count - 1)];
    }
}
