/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: HTCFactory.cs
 *  Desciption: This class inherits from the PhoneFactory interface and implements 
 *              GetDumb amd GetSmart to find the smart and dumb phones for the manufacturer.
 */

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
