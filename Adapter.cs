using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    interface ITarget
    {
        int CalculateAverage();
        int CalculateSum();
    }

    public class Adapter : ITarget
    {
        private IExistingInterface _existing;

        public Adapter(IExistingInterface existing)
        {
            _existing = existing;
        }

        public int CalculateAverage()
        {
            int sum = _existing.D() + 5;
            int count = _existing.E() + 2 * _existing.C();
            return sum / count;
        }

        public int CalculateSum()
        {
            return _existing.D() + 5 + _existing.E() + 2 *
           _existing.C();
        }
    }


}
