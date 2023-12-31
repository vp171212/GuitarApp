﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopApp.Model
{
    internal class FindGuitarTester
    {
        public static void testErin()
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Builder.Fender, "Stratocastor", Type.electric, Wood.Alder, Wood.Alder, 6);
            List<Guitar> guitars = inventory.search(whatErinLikes);
            if (guitars.Count > 0)
            {
                string msgSuccess = "Erin, you might like these guitars: ";
                foreach (Guitar guitar in guitars)
                {
                    GuitarSpec spec = guitar.spec;
                    msgSuccess += "\nWe have a " +
                        Enumerations.GetEnumDescription(spec.builder) + " " + spec.model + " " +
                        Enumerations.GetEnumDescription(spec.type) + " guitar:\n    " +
                        Enumerations.GetEnumDescription(spec.backWood) + " back and sides,\n    " +
                        Enumerations.GetEnumDescription(spec.topWood) + " top.\nYou can have it for only $" +
                        guitar.price + "!\n  ----";
                }
                Console.WriteLine(msgSuccess);
                Console.ReadKey();
            }
            else
            {
                string msgFail = "Sorry, Erin, we have nothing for you.";
                Console.WriteLine(msgFail);
                Console.ReadKey();
            }
        }

        private static void initializeInventory(Inventory inventory)
        {
            inventory.addGuitar("V12345", 1345.55, new GuitarSpec(Builder.Fender, "Stratocastor", Type.electric, Wood.Alder, Wood.Adirondack, 6));
            inventory.addGuitar("A21457", 900.55, new GuitarSpec(Builder.Collings, "OakTown Goove", Type.acoustic, Wood.Brazilian_Rosewood, Wood.Cedar, 6));
            inventory.addGuitar("V95693", 1499.95, new GuitarSpec(Builder.Fender, "Stratocastor", Type.electric, Wood.Alder, Wood.Alder, 6));
            inventory.addGuitar("X54321", 430.54, new GuitarSpec(Builder.Martin, "Stratocastor Light", Type.electric, Wood.Indian_Rosewood, Wood.Maple, 6));
            inventory.addGuitar("X99876", 2000.00, new GuitarSpec(Builder.PRS, "Stratocastor FeatherWeight", Type.electric, Wood.Sitka, Wood.Cocobolo, 6));
            inventory.addGuitar("V9512", 1549.95, new GuitarSpec(Builder.Fender, "Stratocastor", Type.electric, Wood.Alder, Wood.Alder, 6));
        }
    }
}
