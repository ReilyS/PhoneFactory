using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    interface PhoneFactory
    {
        Smart GetSmart();

        Dumb GetDumb();
    }
}
