using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternAdapter;

namespace PatternAdapter
{
    // методы которые будут использоваться в адапторе
    public class ExistingImplementation : IExistingInterface
    {
        public int A()
        {
            return 1;
        }

        public int C()
        {
            return 1;
        }

        public int D()
        {
           
            return 2;
        }

        public int E()
        {
            return 6;
        }
    }

}
