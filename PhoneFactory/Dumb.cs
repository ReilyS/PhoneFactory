/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: Dumb.cs
 *  Desciption: This interface creates a getName function that will be used to get the dumb 
 *              phone's name, getName will be overwritten by the classes that inherit from it.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    interface Dumb
    {
        public string getName();
    }
}
