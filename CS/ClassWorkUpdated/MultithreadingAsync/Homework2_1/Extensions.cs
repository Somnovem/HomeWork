using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_1
{
    public static partial class Extensions
    {
        public static bool IsPrime(this Int32 @this)
        {
            if (@this == 1 || @this == 2)
            {
                return true;
            }

            if (@this % 2 == 0)
            {
                return false;
            }

            var sqrt = (Int32)Math.Sqrt(@this);
            for (Int64 t = 3; t <= sqrt; t += 2)
            {
                if (@this % t == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
