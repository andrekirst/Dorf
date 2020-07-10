using System;

namespace Dorf.Engine
{
    public interface IRandomizer
    {
        int Next(int min, int max);
    }

    public class RandomRandomizer : IRandomizer
    {
        public int Next(int min, int max) => new Random().Next(min, max);
    }
}
