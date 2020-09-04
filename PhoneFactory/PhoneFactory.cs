/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: PhoneFactory.cs
 *  Desciption: Interface for the different types of phone factories. The interface creates functions GetSmart and GetDumb
 *              so that the different factories can get the names of their smart and dumb phones.
 */

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
