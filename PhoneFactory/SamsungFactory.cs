using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    class SamsungFactory : PhoneFactory
    {
        public Dumb GetDumb()
        {
            Dumb returnDumb = new Genie();
            return returnDumb;
        }

        public Smart GetSmart()
        {
            Smart returnSmart = new GalaxyS2();
            return returnSmart;
        }
    }
}
