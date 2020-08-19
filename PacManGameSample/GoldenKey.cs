using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    class GoldenKey : Ikey
    {
        public Cell Cell { get; set; }

        public void OpenBox(BoxStrategy boxStrategy)
        {
            var type = boxStrategy.GetType();
            if (type == typeof(GoldenBox))
                Console.WriteLine($"Golden key is opening : {boxStrategy.ToString()} ");
            else
                Console.WriteLine("this key is not suitable for this box");
        }
    }
}
