using System;
using System.Collections.Generic;
using System.Text;

namespace Preprocessor
{
#pragma warning disable 219
    class Class1
    {
        public Class1()
        {
#pragma warning restore 219
            int x = 10;
        }
    }
}
