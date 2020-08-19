using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample.Box_Factory
{
    interface IBoxCreator
    {
        BoxStrategy CreateBox();
    }
}
