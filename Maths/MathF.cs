using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EilexEngine
{
    public static class MathF
    {
        public static float Lerp(float a, float b, float time)
        {
            return (1f - time) * a + time * b;
        }
    }
}
