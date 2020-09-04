/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: Titan.cs
 *  Desciption: This class inherits from the Smart interface and overwrites 
 *              getName to return the name of the phone.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    class Titan : Smart
    {
        public string getName()
        {
            return "Titan";
        }
    }
}
