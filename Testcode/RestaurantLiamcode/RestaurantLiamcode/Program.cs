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
    public class Gerechten
    {

        public static void Main()
        {
            var JSONoptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            List<Menu> menuItems = new List<Menu>();
            List<Reservaties> Tafels = new List<Reservaties>();
            //List<medeLogin> medeLoginItems = new List<medeLogin>();

            //medeLoginItems.Add(new medeLogin() { Login = "Testlogin", Password = "Testpassword", Name = "Rafael J." });
            //medeLoginItems.Add(new medeLogin() { Login = "LoginTest", Password = "PasswordTest", Name = "Jafael R." });

            //string fileNameMedewerkersLogin = @"..\..\..\..\..\..\..\project-b-restaurant\Testcode\RestaurantLiamcode\RestaurantLiamcode\medewerkersLogin.json";
            //string jsonStringMedewerkers = JsonSerializer.Serialize(medeLoginItems, JSONoptions);
            //File.WriteAllText(fileNameMedewerkersLogin, jsonStringMedewerkers);

            //add new tables to reservations
            Tafels.Add(new Reservaties() { Beschikbaar = "Niet", TafelID = 1, Locatie = "Buiten" });
            Tafels.Add(new Reservaties() { Beschikbaar = "Wel", TafelID = 2, Locatie = "Buiten" });
            Tafels.Add(new Reservaties() { Beschikbaar = "Niet", TafelID = 3, Locatie = "Binnen" });
            Tafels.Add(new Reservaties() { Beschikbaar = "Wel", TafelID = 4, Locatie = "Buiten" });


            // Gerechten toevoegen
            menuItems.Add(new Menu() { Gerechtnaam = "Kolokithopita", Prijs = "10,50", Desc = "Bladerdeeghapjes met feta en courgette", Allergenen = new string[] { "ei", "tarwe", "zuivel" } });
            menuItems.Add(new Menu() { Gerechtnaam = "Rizogalo", Prijs = "5,-", Desc = "Griekse rijstepap", Allergenen = new string[] { "ei", "zuivel" } });
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
            Console.WriteLine("Druk 1 om naar menu te gaan, druk 2 om daar te gaan, druk 3 om gebruikers te toevoegen, druk 4 om in te loggen");

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
            else if (Choice == "3")
            {

                Console.WriteLine("Type your email address");

                string email = Console.ReadLine();

                //relative file location, should work on every pc
                string fileNameKlantReg = @"..\..\..\..\..\..\..\project-b-restaurant\Testcode\RestaurantLiamcode\RestaurantLiamcode\klantReg.json";
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

                //serializes list again
                string jsonStringKlanten = JsonSerializer.Serialize(clientlist, JSONoptions);

                //overwrites list with new entry
                File.WriteAllText(fileNameKlantReg, jsonStringKlanten);
            }


            else if (Choice == "4")
            {
                Console.WriteLine("Press 1 to log in as guest, press 2 to log in as medewerker, press 3 to log in as beheerder");
                string choiceLogin = Console.ReadLine();
                if (choiceLogin == "1")
                {
                    string fileNameKlantReg = @"..\..\..\..\..\..\..\project-b-restaurant\Testcode\RestaurantLiamcode\RestaurantLiamcode\klantReg.json";
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

                if (choiceLogin == "2")
                {
                    Console.WriteLine("Login:");
                    string loginMedewerker = Console.ReadLine();

                    string fileNameMedewerkersLogin = @"..\..\..\..\..\..\..\project-b-restaurant\Testcode\RestaurantLiamcode\RestaurantLiamcode\medewerkersLogin.json";
                    var jsonData = File.ReadAllText(fileNameMedewerkersLogin);

                    //deserializes and puts data into list
                    var medewerkersList = JsonSerializer.Deserialize<List<medeLogin>>(jsonData)
                          ?? new List<medeLogin>();

                    string jsonString = JsonSerializer.Serialize(medewerkersList, JSONoptions);

                    if (jsonString.Contains(loginMedewerker))
                    {
                        Console.WriteLine("Password:");
                        string passwordMedewerker = Console.ReadLine();

                        if (jsonString.Contains(passwordMedewerker))
                        {
                            Console.WriteLine(medewerkersList[1]);
                            Console.WriteLine("Welcome");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Username does not exist");
                    }
                    
                    

                }


            }

        }

    }
}