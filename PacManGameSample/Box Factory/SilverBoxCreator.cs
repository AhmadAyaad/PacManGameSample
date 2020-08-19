using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample.Box_Factory
{
    class SilverBoxCreator : IBoxCreator
    {
        public BoxStrategy CreateBox()
        {
            Console.WriteLine("Silver box has been created");
            return new SilverBox();
        }
    }
}
