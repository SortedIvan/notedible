using System;
using System.Collections.Generic;
using System.Text;

namespace NotEdible
{
    public static class Utility
    {
        public static int GetRandomNum(int maxRange)
        {
            Random random = new Random();
            return random.Next(0, maxRange);
        }
        
    }
}
