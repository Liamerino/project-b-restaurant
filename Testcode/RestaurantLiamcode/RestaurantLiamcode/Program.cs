using System;
//makes list work DONT DELETE
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

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
    //class for reservations
    public class Reservaties
    {
        public string Beschikbaar { get; set; }
        public int TafelID { get; set; }
        public string Locatie { get; set; }
        //makes it possible to print class elements
        public override string ToString()
        {
            return "Beschikbaarheid: " + Beschikbaar + ", Tafelnummer: " + TafelID + ", Binnen of buiten: " + Locatie;
        }
    }

    //class for client registration
    public class klantReg
    {
        public string Email { get; set; }
        public string Reservation { get; set; }

    }

    public class medeLogin
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

    }
    public class MainMenu
    {

        public static void Main()
        {









            //add new tables to reservations



            // Gerechten toevoegen
            //Console.WriteLine("Welkom je zit nu in main menu");
            //Console.WriteLine("Druk 1 om naar menu te gaan, druk 2 om daar te gaan, druk 3 om gebruikers te toevoegen, druk 4 om in te loggen");
            Console.WriteLine("╒════════════════════════════════════════════════╕");
            Console.WriteLine("│  x   Welkom bij restaurant Alicante       x    │");
            Console.WriteLine("│x Type 1 om het menu te bekijken.               │");
            Console.WriteLine("│x Type 2 om te reserveren.                      │");
            Console.WriteLine("│x Type 3 om een gebruiker aan te maken.         │");
            Console.WriteLine("│x Type 4 om als medewerker in te loggen.        │");
            Console.WriteLine("│x Type 5 om als guest in te loggen              │");
            Console.WriteLine("│x Type 6 om als admin in te loggen              │");
            Console.WriteLine("╘════════════════════════════════════════════════╛");
            Console.WriteLine("                                                ");
            Console.WriteLine("╒═════════════════════════════════════════════╕");
            Console.WriteLine("│ Openingstijden: elke dag van 8:00 tot 22:00 │");
            Console.WriteLine("│ Locatie: Oostkousdijk 5                     │");
            Console.WriteLine("│ We zien u graag snel!                       │");
            Console.WriteLine("╘═════════════════════════════════════════════╛");
            //Reads input
            string Choice = Console.ReadLine();
            if (Choice == "1")
            {
                choice1();
            }

            else if (Choice == "2")
            {
                choice2();
            }
            else if (Choice == "3")
            {
                choice3();
            }


            else if (Choice == "4")
            {
                choice4();
            }

            else if (Choice == "5")
            {
                choice5();
            }

        }
        private static List<string> Filter()
        {
            Console.WriteLine("╒════════════════════════════════════════════════════════════════╕");
            Console.WriteLine("│ Filteren op allergenen                                         │");
            Console.WriteLine("│ x Type 1 om gerechten met ei uit de menukaart te halen         │");
            Console.WriteLine("│ x Type 2 om gerechten met gevogelte uit de menukaart te halen  │");
            Console.WriteLine("│ x Type 3 om gerechten met lam uit de menukaart te halen        │");
            Console.WriteLine("│ x Type 4 om gerechten met rund uit de menukaart te halen       │");
            Console.WriteLine("│ x Type 5 om gerechten met sesam uit de menukaart te halen      │");
            Console.WriteLine("│ x Type 6 om gerechten met tarwe uit de menukaart te halen      │");
            Console.WriteLine("│ x Type 7 om gerechten met vis uit de menukaart te halen        │");
            Console.WriteLine("│ x Type 8 om gerechten met weekdieren uit de menukaart te halen │");
            Console.WriteLine("│ x Type 9 om gerechten met zuivel uit de menukaart te halen     │");
            Console.WriteLine("│ x Type kaart om de filters toe te passen op de menukaart       │");
            Console.WriteLine("╘════════════════════════════════════════════════════════════════╛");
            List<string> filterList = new List<string>();
            for (int i = 0; i <= 10; i++)
            {
                string filterChoice = Console.ReadLine();
                if (filterChoice == "1")
                {
                    filterList.Add("ei");
                }
                else if (filterChoice == "2")
                {
                    filterList.Add("gevogelte");
                }
                else if (filterChoice == "3")
                {
                    filterList.Add("lam");
                }
                else if (filterChoice == "4")
                {
                    filterList.Add("rund");
                }
                else if (filterChoice == "5")
                {
                    filterList.Add("sesam");
                }
                else if (filterChoice == "6")
                {
                    filterList.Add("tarwe");
                }
                else if (filterChoice == "7")
                {
                    filterList.Add("vis");
                }
                else if (filterChoice == "8")
                {
                    filterList.Add("weekdieren");
                }
                else if (filterChoice == "9")
                {
                    filterList.Add("zuivel");
                }
                else if (filterChoice == "kaart")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("De waarde die u heeft ingevoerd past niet bij een allergeen. Type een getal of type kaart.");
                }
            }
            return filterList;
        }



        private static void choice1()
        {
            List<Menu> menuItems = new List<Menu>();
            menuItems.Add(new Menu() { Gerechtnaam = "Kolokithopita         ", Prijs = "10,50", Desc = "Bladerdeeghapjes met feta en courgette                    ", Allergenen = new string[] { "ei", "tarwe", "zuivel" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Rizogalo              ", Prijs = "5,-  ", Desc = "Griekse rijstepap                                         ", Allergenen = new string[] { "ei", "zuivel" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Koulouri Thessalonikis", Prijs = "6,50 ", Desc = "Rond sesambrood                                           ", Allergenen = new string[] { "tarwe", "sesam" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Marides tiganites     ", Prijs = "11,- ", Desc = "Knapperig gefrituurde sardines                            ", Allergenen = new string[] { "tarwe", "vis" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Piadine               ", Prijs = "7,-  ", Desc = "Platbrood met mozarella en tomaat                         ", Allergenen = new string[] { "tarwe", "zuivel" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Italiaanse quiche     ", Prijs = "10,50", Desc = "Quiche met pesto en mozarella                             ", Allergenen = new string[] { "ei", "tarwe", "zuivel" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Bruschetta            ", Prijs = "6,50,", Desc = "Toast met knoflook en tomaten                             ", Allergenen = new string[] { "tarwe" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Calamari salade       ", Prijs = "11,- ", Desc = "Salade met octopus                                        ", Allergenen = new string[] { "weekdieren" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Empanadas             ", Prijs = "10,50", Desc = "Gefrituurde deeghapjes met gekruid gehakt                 ", Allergenen = new string[] { "ei", "tarwe", "rund" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Croquettes            ", Prijs = "12,- ", Desc = "Knapperig gefrituurde deeghapjes met ham, kip of kabeljauw", Allergenen = new string[] { "ei", "gevogelte", "varken", "vis", "zuivel" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Albondigas            ", Prijs = "8,50 ", Desc = "Gehaktballen met pittige saus                             ", Allergenen = new string[] { "ei", "tarwe", "rund", "varken" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Gambas al ajillo      ", Prijs = "12,- ", Desc = "Garnalen met knoflook                                     ", Allergenen = new string[] { "weekdieren" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Lahmacun              ", Prijs = "6,50 ", Desc = "Kleine turkse pizza's                                     ", Allergenen = new string[] { "tarwe", "rund" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Çig köfte             ", Prijs = "8,50 ", Desc = "Gekruid lamsgehakt op een stokje                          ", Allergenen = new string[] { "lam", "tarwe" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Kabak mücveri         ", Prijs = "7,50 ", Desc = "Gebakken geschaafde courgette                             ", Allergenen = new string[] { "ei", "tarwe" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Kisir                 ", Prijs = "6,50 ", Desc = "Salade met bulgur                                         ", Allergenen = new string[] { "tarwe" } });

            int i = 0;
            string[] keukenArr = new string[] {
                    "Grieks   ",
                    "Italiaans",
                    "Spaans   ",
                    "Turks    " };
            Console.WriteLine("╒════════════════════════════════════════════════════════════════════════════════════════════╕");
            Console.WriteLine("│ Menukaart                                                                                  │");
            foreach (Menu aMenu in menuItems)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("│                                                                                            │");
                    Console.WriteLine($"│ {keukenArr[i / 4]}                                                                                  │");
                }
                Console.WriteLine($"│ {aMenu} │");
                i++;
            }
            Console.WriteLine("│                                                                                            │");
            Console.WriteLine("│ Type 1 om te filteren op allergenen                                                        │");
            Console.WriteLine("│ Type menu om terug te gaan naar het hoofdmenu                                              │");
            Console.WriteLine("╘════════════════════════════════════════════════════════════════════════════════════════════╛");
            string menukaartChoice = Console.ReadLine();
            if (menukaartChoice == "1")
            {
                var filterList = Filter();
                int filterI = 0;
                Console.WriteLine("╒════════════════════════════════════════════════════════════════════════════════════════════╕");
                Console.WriteLine("│ Menukaart                                                                                  │");
                foreach (Menu aMenu in menuItems)
                {
                    if (filterI % 4 == 0)
                    {
                        Console.WriteLine("│                                                                                            │");
                        Console.WriteLine($"│ {keukenArr[filterI / 4]}                                                                                  │");
                    }
                    bool allergeenIn = false;
                    for (int j = 0; j<menuItems[filterI].Allergenen.Length; j++)
                    {
                        if (filterList.Contains(menuItems[filterI].Allergenen[j]))
                        {
                            allergeenIn = true;
                            break;
                        }
                    }
                    if (!allergeenIn)
                    {
                        Console.WriteLine($"│ {aMenu} │");
                    }
                    filterI++;
                }
                Console.WriteLine("│                                                                                            │");
                Console.WriteLine("│ Type 1 om te filteren op allergenen                                                        │");
                Console.WriteLine("│ Type menu om terug te gaan naar het hoofdmenu                                              │");
                Console.WriteLine("╘════════════════════════════════════════════════════════════════════════════════════════════╛");
            }

        }

        private static void choice2()
        {
            List<Reservaties> Tafels = new List<Reservaties>();
            Tafels.Add(new Reservaties() { Beschikbaar = "Niet", TafelID = 1, Locatie = "Buiten" });
            Tafels.Add(new Reservaties() { Beschikbaar = "Wel", TafelID = 2, Locatie = "Buiten" });
            Tafels.Add(new Reservaties() { Beschikbaar = "Niet", TafelID = 3, Locatie = "Binnen" });
            Tafels.Add(new Reservaties() { Beschikbaar = "Wel", TafelID = 4, Locatie = "Buiten" });
            Console.WriteLine("Reserveringen");
            foreach (Reservaties aReservaties in Tafels)
            {
                Console.WriteLine(aReservaties);
            }

        }

        private static void choice3()
        {


            string email = Console.ReadLine();

            //relative file location, should work on every pc
            string fileNameKlantReg = @"..\..\..\klantReg.json";
            var jsonData = File.ReadAllText(fileNameKlantReg);

            //deserializes and puts data into list
            var clientlist = JsonSerializer.Deserialize<List<klantReg>>(jsonData)
                  ?? new List<klantReg>();

            //adds new entry to list
            clientlist.Add(new klantReg()
            {
                Email = email,
                Reservation = "none"
            });
            var JSONoptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            //serializes list again
            string jsonStringKlanten = JsonSerializer.Serialize(clientlist, JSONoptions);

            //overwrites list with new entry
            File.WriteAllText(fileNameKlantReg, jsonStringKlanten);
        }

        private static void choice4()
        {
            string fileNameMedewerkersLogin = @"..\..\..\medewerkersLogin.json";
            var jsonData = File.ReadAllText(fileNameMedewerkersLogin);

            var medewerkersList = JsonSerializer.Deserialize<List<List<medeLogin>>>(jsonData);

            Console.WriteLine("Voer gebruikersnaam in om door te gaan:");
            string loginMedewerker = Console.ReadLine();
            Console.WriteLine("Voer wachtwoord in om door te gaan");
            string passwordMedewerker = Console.ReadLine();
            int listlength = medewerkersList.Count;
            for (int i = 0; i < listlength; i++)
            {
                if (medewerkersList[i][0].Login == loginMedewerker && medewerkersList[i][0].Password == passwordMedewerker)
                {
                    Console.Clear();
                    Main();
                    //instead of main, MedewerkerMain() should be created
                    return;
                }
                else if (i == (listlength - 1) && loginMedewerker != medewerkersList[i][0].Login && passwordMedewerker != medewerkersList[i][0].Password)
                {
                    Console.WriteLine("Verkeerde gebruikersnaam of wachtwoord, probeer opnieuw");
                    choice4();
                }
            }
        }
        private static void choice5()
        {
            var JSONoptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            string fileNameKlantReg = @"..\..\..\klantReg.json";
            var jsonData = File.ReadAllText(fileNameKlantReg);
            var clientlist = JsonSerializer.Deserialize<List<klantReg>>(jsonData)
                ?? new List<klantReg>();
            string jsonString = JsonSerializer.Serialize(clientlist, JSONoptions);
            string input = Console.ReadLine();

            //checks if input is already in Json file, if not, informs user does not exist

            if (jsonString.Contains(input) & input != "none")
            {
                Console.WriteLine("You are logged in");
            }
            else
            {
                Console.WriteLine("user does not exist");
            }
        }



    }

    }
