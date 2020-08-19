using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    class BronzeKey : Ikey
    {
        public Cell Cell { get; set; }

        public void OpenBox(BoxStrategy boxStrategy)
        {
            var type = boxStrategy.GetType();
            if (type == typeof(BronzeBox))
                Console.WriteLine($"Bronze key is opening : {boxStrategy.ToString()} ");
            else
                Console.WriteLine("this key is not suitable for this box");
        }
    }
}
