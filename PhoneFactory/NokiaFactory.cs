using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    class NokiaFactory : PhoneFactory
    {
        public Dumb GetDumb()
        {
            Dumb returnDumb = new Asha();
            return returnDumb;
        }

        public Smart GetSmart()
        {
            Smart returnSmart = new Lumia();
            return returnSmart;
        }
    }
}
