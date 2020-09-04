/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: Smart.cs
 *  Desciption: This interface creates a getName function that will be used to get the smart 
 *              phone's name, getName will be overwritten by the classes that inherit from it.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    interface Smart
    {
        public string getName();
    }
}
