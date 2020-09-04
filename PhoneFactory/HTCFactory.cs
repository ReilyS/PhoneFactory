using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    class HTCFactory : PhoneFactory
    {
        public Dumb GetDumb()
        {
            Dumb returnDumb = new Primo();
            return returnDumb;
        }

        public Smart GetSmart()
        {
            Smart returnSmart = new Titan();
            return returnSmart;
        }
    }
}
