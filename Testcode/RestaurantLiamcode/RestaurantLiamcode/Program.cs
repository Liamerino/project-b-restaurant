using System;
//makes list work DONT DELETE
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace RestaurantLiamCode
{
    public static class Reserveringen
    {
        public static List<Tuple<string, string, int>> reserveringen = new List<Tuple<string, string, int>>();


    }
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

    public class adminLogin
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }

    public class MainMenu
    {

        public static void Main()
        {


            //    List<Tuple<string, string, int>> reserveringen = new List<Tuple<string, string, int>>();






            //add new tables to reservations



            // Gerechten toevoegen
            //Console.WriteLine("Welkom je zit nu in main menu");
            //Console.WriteLine("Druk 1 om naar menu te gaan, druk 2 om daar te gaan, druk 3 om gebruikers te toevoegen, druk 4 om in te loggen");
            Console.WriteLine("╒════════════════════════════════════════════════╕");
            Console.WriteLine("│  x     Welkom bij restaurant Alicante       x  │");
            Console.WriteLine("│x Type 1 om het menu te bekijken.               │");
            Console.WriteLine("│x Type 2 om een tafel te reserveren.            │");
            Console.WriteLine("│x Type 3 om als medewerker in te loggen.        │");
            Console.WriteLine("│x Type 4 om als admin in te loggen.             │");
            Console.WriteLine("╘════════════════════════════════════════════════╛");
            Console.WriteLine("                                                ");
            Console.WriteLine("╒═════════════════════════════════════════════╕");
            Console.WriteLine("│ Openingstijden: elke dag van 8:00 tot 22:00 │");
            Console.WriteLine("│ Locatie: Oostkousdijk 5                     │");
            Console.WriteLine("│ Sfeer:Een frisse zeewind in je haren terwijl│");
            Console.WriteLine("│ je kijkt naar dobberende bootjes in een     │");
            Console.WriteLine("│ oude haven.                                 │");
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


        }

        public static void MainMedewerker(){
            //List<Tuple<string, string, int>> reserveringen = new List<Tuple<string, string, int>>();
            Console.WriteLine("╒════════════════════════════════════════════════╕");
            Console.WriteLine("│  x             Welkom medewerker            x  │");
            Console.WriteLine("│x Type 1 om het menu te bekijken.               │");
            Console.WriteLine("│x Type 2 om een tafel te reserveren.            │");
            Console.WriteLine("│x Type 3 om te bestellen voor een tafel.        │");
            Console.WriteLine("│x Type 4 om de tafelbezetting te zien.          │");
            Console.WriteLine("│x Type 5 om uit te loggen.                      │");
            Console.WriteLine("╘════════════════════════════════════════════════╛");
            Console.WriteLine("                                                ");
            Console.WriteLine("╒═════════════════════════════════════════════╕");
            Console.WriteLine("│ Openingstijden: elke dag van 8:00 tot 22:00 │");
            Console.WriteLine("│ Locatie: Oostkousdijk 5                     │");
            Console.WriteLine("│ Sfeer:Een frisse zeewind in je haren terwijl│");
            Console.WriteLine("│ je kijkt naar dobberende bootjes in een     │");
            Console.WriteLine("│ oude haven.                                 │");

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
                choice5u();
            }

        }

        public static void MainAdmin()
        {
            //List<Tuple<string, string, int>> reserveringen = new List<Tuple<string, string, int>>();
            Console.WriteLine("╒════════════════════════════════════════════════╕");
            Console.WriteLine("│  x               Welkom Admin                 x│");
            Console.WriteLine("│x Type 1 om de dagomzet te bekijken.            │");
            Console.WriteLine("│x Type 2 om gebruikers aan te maken.            │");
            Console.WriteLine("│x Type 3 om uit te loggen                       │");
            Console.WriteLine("╘════════════════════════════════════════════════╛");
            Console.WriteLine("                                                ");
            Console.WriteLine("╒═════════════════════════════════════════════╕");
            Console.WriteLine("│ Openingstijden: elke dag van 8:00 tot 22:00 │");
            Console.WriteLine("│ Locatie: Oostkousdijk 5                     │");
            Console.WriteLine("│ Sfeer:Een frisse zeewind in je haren terwijl│");
            Console.WriteLine("│ je kijkt naar dobberende bootjes in een     │");
            Console.WriteLine("│ oude haven.                                 │");
            Console.WriteLine("╘═════════════════════════════════════════════╛");
            //Reads input
            string Choice = Console.ReadLine();
            if (Choice == "1")
            {
                choice1Admin();
            }

            else if (Choice == "2")
            {
                choice2Admin();
            }
            else if (Choice == "3")
            {
                choice3Admin();
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
            if (menukaartChoice == "menu")
            {
                Console.Clear();
                Main();
            }
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
            menukaartChoice = Console.ReadLine();
            if (menukaartChoice == "menu")
            {
                Console.Clear();
                Main();
            }

        }

        private static void choice2()
        {
            int plekken = 150;
            Console.WriteLine("Reserveren");
            Console.WriteLine("Voor welke datum wilt u reserveren? Type dit alstublieft als DD-MM-JJJJ");
            string datum = Console.ReadLine();
            Console.WriteLine("Hoe laat wilt u reserveren? Type dit alstublieft als uur:minuten");
            string tijd = Console.ReadLine();
            int plekkenTijdstip = 0;
            for (int i = 0; i<Reserveringen.reserveringen.Count; i++)
            {
                if (Reserveringen.reserveringen[i].Item1 == datum && Reserveringen.reserveringen[i].Item2 == tijd)
                {
                    plekkenTijdstip = plekkenTijdstip + Reserveringen.reserveringen[i].Item3;
                }
                if (plekkenTijdstip >= plekken)
                {
                    Console.WriteLine("╒═════════════════════════════════════════════════════╕");
                    Console.WriteLine("│ Deze datum en dit tijdstip zijn niet beschikbaar.   │");
                    Console.WriteLine("│ Type 1 om een ander datum en tijdstip te reserveren.│");
                    Console.WriteLine("│ Type menu om terug te gaan naar het hoofdmenu.      │");
                    Console.WriteLine("╘═════════════════════════════════════════════════════╛");
                    string reservChoice = Console.ReadLine();
                    if (reservChoice == "menu")
                    {
                        Main();
                        break;
                    }
                    if (reservChoice == "1")
                    {
                        choice2();
                        break;
                    }
                }
            }
            Console.WriteLine("Voor hoeveel personen wilt u reserveren?");
            int personen = Int16.Parse(Console.ReadLine());
            if (plekkenTijdstip + personen <= plekken)
            {
                Reserveringen.reserveringen.Add(Tuple.Create(datum, tijd, personen));
                Console.WriteLine("╒═══════════════════════════════════════════════════════════╕");
                Console.WriteLine("│ U heeft gereserveerd.                                     │");
                Console.WriteLine($"│ Uw reservering is op {datum} om {tijd} voor {personen} personen. │");
                Console.WriteLine("│ Type menu om terug te gaan naar het hoofdmenu.            │");
                Console.WriteLine("╘═══════════════════════════════════════════════════════════╛");
                string reservChoice = Console.ReadLine();
                if (reservChoice == "menu")
                {
                    Console.Clear();
                    Main();
                    //return reserveringen;
                }
            }
            else
            {
                Console.WriteLine("╒═════════════════════════════════════════════════════╕");
                Console.WriteLine("│ Deze datum en dit tijdstip zijn niet beschikbaar.   │");
                Console.WriteLine("│ Type 1 om een ander datum en tijdstip te reserveren.│");
                Console.WriteLine("│ Type menu om terug te gaan naar het hoofdmenu.      │");
                Console.WriteLine("╘═════════════════════════════════════════════════════╛");
                string reservChoice = Console.ReadLine();
                if (reservChoice == "menu")
                {
                    Console.Clear();
                    Main();
                    //return reserveringen;
                }
                if (reservChoice == "1")
                {
                    Console.Clear();
                    choice2();
                }
            }

        }
        private static void choice3()
        {
            Console.Clear();
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
                    MainMedewerker();
                    return;
                }
                else if (i == (listlength - 1) && loginMedewerker != medewerkersList[i][0].Login && passwordMedewerker != medewerkersList[i][0].Password)
                {
                    Console.WriteLine("Verkeerde gebruikersnaam of wachtwoord, typ 1 om opnieuw in te loggen, of typ menu om terug naar menu te gaan");
                    string choiceInloggen = Console.ReadLine();
                    if (choiceInloggen == "1")
                    {
                        choice3();
                    }
                    else if (choiceInloggen == "menu")
                    {
                        Console.Clear();
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Verkeerde input");
                        choice3();
                    }
                }
            }
        }

        private static void choice4()
        {
            Console.Clear();
            string fileNameAdminLogin = @"..\..\..\adminLogin.json";
            var jsonData = File.ReadAllText(fileNameAdminLogin);

            var adminList = JsonSerializer.Deserialize<List<List<adminLogin>>>(jsonData);

            Console.WriteLine("Voer gebruikersnaam in om door te gaan:");
            string loginAdmin = Console.ReadLine();
            Console.WriteLine("Voer wachtwoord in om door te gaan");
            string passwordAdmin = Console.ReadLine();
            int listlength = adminList.Count;
            for (int i = 0; i < listlength; i++)
            {
                if (adminList[i][0].Login == loginAdmin && adminList[i][0].Password == passwordAdmin)
                {
                    Console.Clear();
                    MainAdmin();
                    return;
                }
                else if (i == (listlength - 1) && loginAdmin != adminList[i][0].Login && passwordAdmin != adminList[i][0].Password)
                {
                    Console.WriteLine("Verkeerde gebruikersnaam of wachtwoord, typ 1 om opnieuw in te loggen, of typ menu om terug naar menu te gaan");
                    string choiceInloggen = Console.ReadLine();
                    if (choiceInloggen == "1")
                    {
                        choice4();
                    }
                    else if (choiceInloggen == "menu")
                    {
                        Console.Clear();
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Verkeerde input");
                        choice3();
                    }
                }
            }

        }

        public static void choice5u()
        {
            Console.WriteLine("Wilt u zeker uitloggen? Typ 1 om uit te loggen");
            string confirmation = Console.ReadLine();
            if (confirmation == "1")
            {
                Console.Clear();
                Main();
            }
        }

        public static void choice1Admin()
        {
            Console.WriteLine("Hier komt de dagomzet");
        }

        public static void choice2Admin()
        {
            Console.Clear();

            var JSONoptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            Console.WriteLine("Voer in gewenste gebruikersnaam");
            string newLogin = Console.ReadLine();

            Console.WriteLine("Voer in gewenste wachtwoord");
            string newPassword = Console.ReadLine();

            Console.WriteLine("Voer in naam en achternaam van de gebruiker");
            string newName = Console.ReadLine();

            string fileNameMedewerkersLogin = @"..\..\..\medewerkersLogin.json";
            var jsonData = File.ReadAllText(fileNameMedewerkersLogin);

            var UsersList = JsonSerializer.Deserialize<List<List<medeLogin>>>(jsonData);

            List<medeLogin> sublist = new List<medeLogin>();
            sublist.Add(new medeLogin() { Login = newLogin, Password = newPassword, Name = newName });
            UsersList.Add(sublist);



            string jsonString = JsonSerializer.Serialize(UsersList, JSONoptions);
            File.WriteAllText(fileNameMedewerkersLogin, jsonString);
            Console.Clear();
            Console.WriteLine("Gebruiker " + newName + " toegevoegd.");
            MainAdmin();


        }

        public static void choice3Admin()
        {
            Console.WriteLine("Wilt u zeker uitloggen? Typ 1 om uit te loggen");
            string confirmation = Console.ReadLine();
            if (confirmation == "1")
            {
                Console.Clear();
                Main();
            }
        }

    }

    }
