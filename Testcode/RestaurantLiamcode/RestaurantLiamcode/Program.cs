using System;

//makes list work DONT DELETE
using System.Collections.Generic;

namespace RestaurantLiamCode
{
    public class Menu
    {
        public string Gerechtnaam { get; set; }
        public string Prijs { get; set; }
        public string Desc { get; set; }

        public string[] Allergenen { get; set; }

        public override string ToString()
        {
            return Gerechtnaam + "  " + Prijs + "   " + Desc;
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
            menuItems.Add(new Menu() { Gerechtnaam = "Kolokithopita", Prijs = "10,50", Desc = "Bladerdeeghapjes met feta en courgette", Allergenen = new string[] { "ei", "tarwe", "zuivel" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Rizogalo", Prijs = "5,-", Desc = "Griekse rijstepap", Allergenen = new string[] { "ei", "zuivel"} });
            menuItems.Add(new Menu() { Gerechtnaam = "Koulouri Thessalonikis", Prijs = "6,50", Desc = "Rond sesambrood", Allergenen = new string[] { "tarwe", "sesam" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Marides tiganites", Prijs = "11,-", Desc = "Knapperig gefrituurde sardines", Allergenen = new string[] { "tarwe", "vis" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Piadine", Prijs = "7,-", Desc = "Platbrood met mozarella en tomaat", Allergenen = new string[] { "tarwe", "kaas" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Italiaanse quiche", Prijs = "10,50", Desc = "Quiche met pesto en mozarella", Allergenen = new string[] { "ei", "tarwe", "kaas" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Bruschetta", Prijs = "6,50,-", Desc = "Toast met knoflook en tomaten", Allergenen = new string[] { "tarwe" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Calamari salade", Prijs = "11,-", Desc = "Salade met octopus", Allergenen = new string[] { "weekdieren" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Empanadas", Prijs = "10,50", Desc = "Gefrituurde deeghapjes met gekruid gehakt", Allergenen = new string[] { "ei", "tarwe", "rund" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Croquettes", Prijs = "12,-", Desc = "Knapperig gefrituurde deeghapjes met ham, kip of kabeljauw", Allergenen = new string[] { "ei", "gevogelte", "varken", "vis", "zuivel" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Albondigas", Prijs = "8,50", Desc = "Gehaktballen met pittige saus", Allergenen = new string[] { "ei", "tarwe", "rund", "varken" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Gambas al ajillo", Prijs = "12,-", Desc = "Garnalen met knoflook", Allergenen = new string[] { "weekdieren" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Lahmacun", Prijs = "6,50", Desc = "Kleine turkse pizza's", Allergenen = new string[] { "tarwe", "rund" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Çig köfte", Prijs = "8,50", Desc = "Gekruid lamsgehakt op een stokje", Allergenen = new string[] { "lam", "tarwe" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Kabak mücveri", Prijs = "7,50", Desc = "Gebakken geschaafde courgette", Allergenen = new string[] { "ei", "tarwe" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Kisir", Prijs = "6,50", Desc = "Salade met bulgur", Allergenen = new string[] { "tarwe" } });
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