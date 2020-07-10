using System.Collections.Generic;
using System.Linq;

namespace Dorf.Engine
{
    public interface IWürfelbecher
    {
        int Wuerfeln(IEnumerable<IWürfel> würfel);
    }

    public class Würfelbecher : IWürfelbecher
    {
        public Würfelbecher()
        {
        }

        public int Wuerfeln(IEnumerable<IWürfel> würfel) => würfel.Sum(w => w.Wuerfeln());
    }
}
