using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.OrderedOutput
{
    public class Theory
    {
        private static int _currentMethod;
        private static readonly object _locker = new object();

        public Theory()
        {
            _currentMethod = 0;
        }

        public static void One()
        {
            lock (_locker)
            {
                if (_currentMethod == 0)
                {
                    _currentMethod = 1;
                    Speak.SayOne();
                }
            }
        }

        public static void Two()
        {
            lock (_locker)
            {
                if (_currentMethod == 1)
                {
                    _currentMethod = 2;
                    Speak.SayTwo();
                }
            }
        }

        public static void Three()
        {
            lock (_locker)
            {
                if (_currentMethod == 2)
                {
                    _currentMethod = 0;
                   Speak.SayThree();
                }
            }
        }
    }
}
