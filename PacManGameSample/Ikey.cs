using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    public interface Ikey
    {
        public Cell Cell { get; set; }
        void OpenBox(BoxStrategy boxStrategy);
    }
}
