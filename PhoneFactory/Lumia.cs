/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: Lumia.cs
 *  Desciption: This class inherits from the Smart interface and overwrites 
 *              getName to return the name of the phone.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    class Lumia : Smart
    {
        public string getName()
        {
            return "Lumia";
        }
    }
}
