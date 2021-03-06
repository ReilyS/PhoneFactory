﻿/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: PhoneTypeChecker.cs
 *  Desciption: This class has public variables for the type of PhoneFactory and the value of a given location in 
 *              the enum MANUFACTURERS. It also has a constructor that sets the MANUFACTURERS variable value to 
 *              a passed value and a void function that changes the set factory then prints the phones that
 *              factory makes.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    class PhoneTypeChecker
    {
        public PhoneFactory factory;
        public MANUFACTURERS manu;
        public PhoneTypeChecker(MANUFACTURERS m)
        {
            manu = m;
        }
        public void CheckProducts()
        {
            switch (manu)
            {
                case (MANUFACTURERS)0:
                    factory = new SamsungFactory();
                    Console.WriteLine("Samsung:");
                    break;
                case (MANUFACTURERS)1:
                    factory = new HTCFactory();
                    Console.WriteLine("HTC:");
                    break;
                case (MANUFACTURERS)2:
                    factory = new NokiaFactory();
                    Console.WriteLine("Nokia:");
                    break;
                default:
                    Console.WriteLine("ERROR 404: Phone Factory Not Found.");
                    factory = null;
                    break;
            }

            if (factory != null)
            {
                Console.WriteLine($"Smart Phone: {factory.GetSmart().getName()}.");
                Console.WriteLine($"Dumb Phone: {factory.GetDumb().getName()}.");
            }
        }
    }

    enum MANUFACTURERS
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
}
