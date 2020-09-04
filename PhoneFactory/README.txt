Name: Reily Stanford
Date: 09/04/2020
Description: This program uses a PhoneTypeChecker object in order to loop through and print the smart and dumb phones for every listed manufacturer 
             in the enum MANUFACTURERS. It uses the different types of phone factories that use the PhoneFactory interface and their functions.

Needed Files: Asha.cs
              Dumb.cs
              GalaxyS2.cs
              Genie.cs
              HTCFactory.cs
              Lumia.cs
              NokiaFactory.cs
              PhoneFactory.cs
              PhoneTypeChecker.cs
              Primo.cs
              Program.cs
              SamsungFactory.cs
              Smart.cs
              Titan.cs

Design Decisions: I made checkProducts in PhoneTypeChecker check that the PhoneFactory member variable 
                  was not null before trying to print the phones in order to stop errors.