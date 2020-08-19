using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample.Box_Factory
{
    class BronzeBoxCreator : IBoxCreator
    {
        public BoxStrategy CreateBox()
        {
            Console.WriteLine("Bronze box has been created");
            return new BronzeBox();
        }
    }
}
