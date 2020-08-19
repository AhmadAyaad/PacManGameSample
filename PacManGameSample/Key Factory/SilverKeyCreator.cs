using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample.Key_Factory
{
    class SilverKeyCreator : IkeyCreator
    {
        public Ikey CreateKey()
        {
            return new SilverKey();
        }
    }
}
