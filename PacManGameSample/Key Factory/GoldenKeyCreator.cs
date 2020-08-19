using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample.Key_Factory
{
    class GoldenKeyCreator : IkeyCreator
    {
        public Ikey CreateKey()
        {
            return new GoldenKey();
        }
    }
}
