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
