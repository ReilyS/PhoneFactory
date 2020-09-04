/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: Program.cs
 *  Desciption: This file loops through each phone manufacturer in an enum, using that value to check the smart and dumb phone that the manfacturer's factory makes.
 */

using System;

namespace PhoneFactory
{
    class Program
    {
        static void Main()
        {
            PhoneTypeChecker checkPhone;
            for (int i = 0; i < 4; i++)
            {
                checkPhone = new PhoneTypeChecker((MANUFACTURERS)i);
                checkPhone.CheckProducts();
                Console.WriteLine();
            }
        }
    }
}
