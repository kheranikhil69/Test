using System;
using System.Collections.Generic;
using System.Text;

namespace Preprocessor
{
    class region
    {
        #region ConstructorRegion
        public region()
        {
#warning You have written nothing in this parameterless construtor
        }
        public region(int x)
        {
//#line default
//#error No Data memeber to assign x to
        }
        #endregion
    }
}
