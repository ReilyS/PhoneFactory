/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: SamsungFactory.cs
 *  Desciption: This class inherits from the PhoneFactory interface and implements 
 *              GetDumb amd GetSmart to find the smart and dumb phones for the manufacturer.
 */

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
