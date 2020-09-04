/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: NokiaFactory.cs
 *  Desciption: This class inherits from the PhoneFactory interface and implements 
 *              GetDumb amd GetSmart to find the smart and dumb phones for the manufacturer.
 */

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
