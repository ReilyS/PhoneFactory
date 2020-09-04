/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: Asha.cs
 *  Desciption: This class inherits from the Dumb interface and overwrites 
 *              getName to return the name of the phone.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    class Asha : Dumb
    {
        public string getName()
        {
            return "Asha";
        }
    }
}
