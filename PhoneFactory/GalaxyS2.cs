﻿/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: GalaxyS2.cs
 *  Desciption: This class inherits from the Smart interface and overwrites 
 *              getName to return the name of the phone.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    class GalaxyS2 : Smart
    {
        public string getName()
        {
            return "GalaxyS2";
        }
    }
}
