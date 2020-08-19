using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    class Key
    {
        public Ikey Ikey { get; set; }
        public Key(Ikey k)
        {
            Ikey = k;
        }
        public void OpenBox(BoxStrategy boxStrategy)
        {
            Ikey.OpenBox(boxStrategy);
        }
    }
}
