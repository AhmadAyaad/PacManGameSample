using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample.Key_Factory
{
    class BronzeKeyCreator : IkeyCreator
    {
        public Ikey CreateKey()
        {
            return new BronzeKey();
        }
    }
}
