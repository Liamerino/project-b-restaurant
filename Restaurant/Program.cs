using System;

//makes list work DONT DELETE
using System.Collections.Generic;

namespace Restaurant
{
    public class Menu
    {
        public string Gerechtnaam { get; set; }
        public string Prijs { get; set; }
        public string Desc { get; set; }

        public override string ToString()
        {
            return "Naam: " + Gerechtnaam + ", Prijs: " + Prijs + ", Description: " + Desc;
        }
    }

    public class Reservaties
    {
        public string Beschikbaar { get; set; }
        public int TafelID { get; set; }
        public string Locatie { get; set; }
        public override string ToString()
        {
            return "Beschikbaarheid: " + Beschikbaar + ", Tafelnummer: " + TafelID + ", Binnen of buiten: " + Locatie;
        }
    }
    public class Gerechten
    {

        public static void Main()
        {
            List<Menu> menuItems = new List<Menu>();
            List<Reservaties> Tafels = new List<Reservaties>();

            Tafels.Add(new Reservaties() { Beschikbaar = "Niet", TafelID = 1, Locatie = "Buiten" });
            Tafels.Add(new Reservaties() { Beschikbaar = "Wel", TafelID = 2, Locatie = "Buiten" });
            Tafels.Add(new Reservaties() { Beschikbaar = "Niet", TafelID = 3, Locatie = "Binnen" });
            Tafels.Add(new Reservaties() { Beschikbaar = "Wel", TafelID = 4, Locatie = "Buiten" });


            // Gerechten toevoegen
            menuItems.Add(new Menu() { Gerechtnaam = "Sashimi", Prijs = "20$", Desc = "Lorem ipsum ipsum lorem" });
            menuItems.Add(new Menu() { Gerechtnaam = "Taco", Prijs = "5$", Desc = "Lorem ipsum ipsum lorem 2" });
            menuItems.Add(new Menu() { Gerechtnaam = "Brocadillo", Prijs = "11$", Desc = "Lorem ipsum ipsum lorem 3" });
            menuItems.Add(new Menu() { Gerechtnaam = "Wijn", Prijs = "10$", Desc = "Lorem ipsum ipsum lorem 4" });
            Console.WriteLine("Welkom je zit nu in main menu");
            Console.WriteLine("Druk 1 om naar menu te gaan, druk 2 om daar te gaan");

            //Reads input
            string Choice = Console.ReadLine();
            if (Choice == "1")
            {
                Console.WriteLine("Main menu");
                foreach (Menu aMenu in menuItems)
                {
                    Console.WriteLine(aMenu);
                }
            }
            else if (Choice == "2")
            {
                Console.WriteLine("Reservaties");
                foreach (Reservaties aReservaties in Tafels)
                {
                    Console.WriteLine(aReservaties);
                }
            }

        }

    }
}