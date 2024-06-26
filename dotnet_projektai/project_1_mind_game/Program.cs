using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace project_1_mind_game
{
    internal class Program
    {
        // Vartotojų sąrašas
        static Dictionary<string, int> users = new Dictionary<string, int>
        {
            //{ "Ajus Dudada", 2  },
            //{ "Lukas Lukis", 3  },
            //{ "Atas Batukas", 6  },
            //{ "Jonas Stulpis", 10  },
            //{ "Petras Petriukas", 10  },
            //{ "Kazys Kazlauskas", 8  },
            //{ "Antanas Antanaitis", 3  },
            //{ "Vytas Vytukas", 4  },
            //{ "Mantas Mantukas", 4  },
            //{ "Tomas Tomaitis", 9  },
            //{ "Rokas Rokaitis", 7  },
            //{ "Marius Mariukas", 1  },
            //{ "Darius Dariukas", 9  },
            //{ "Gintaras Gintukas", 2  },
            //{ "Kęstas Kęstukas", 5  },
            //{ "Rimas Rimukas", 6  },
            //{ "Giedrius Giedriukas", 8  },
            //{ "Aurimas Aurukas", 11  },
            //{ "Mindaugas Mindukas", 12  },
            //{ "Aivaras Aivukas", 4  }

            { "Lukas Lukis", 3  },
            { "Atas Batukas", 3  },
            { "Jonas Stulpis", 3  },
            { "Petras Petriukas", 3  },
            { "Kazys Kazlauskas", 3  },
            { "Antanas Antanaitis", 3  },
            { "Vytas Vytukas", 3  },
            { "Mantas Mantukas", 3  },
            { "Tomas Tomaitis", 3  },
            { "Rokas Rokaitis", 3  },
            { "Marius Mariukas", 3  },
            { "Darius Dariukas", 3  },
            { "Gintaras Gintukas", 3  },
            { "Kęstas Kęstukas", 3  },
            { "Rimas Rimukas", 3  }
        };
        // Klausimų sąrašas
        static Dictionary<string, List<string>> questionsAnimals = new Dictionary<string, List<string>>
        {
            { "Kas yra greičiausias sausumos gyvūnas?", new List<string> { "Gepardas", "Liūtas", "Arklys", "Antilopė" } },
            { "Kuris iš šių gyvūnų yra žinduolis?", new List<string> { "Delfinas", "Vėžlys", "Salamandra", "Krokodilas" } },
            { "Kiek kojų turi vabzdžiai?", new List<string> { "6", "4", "8", "10" } },
            { "Kokia grupei priklauso krokodilai, aligatoriai ir kaimanai?", new List<string> { "Ropliai", "Paukščiai", "Žuvys", "Žinduoliai", } },
            { "Kuris paukštis garsėja gebėjimu imituoti žmogaus kalbą?", new List<string> { "Papūga", "Žvirblis", "Gulbė", "Pelikanas" } },
            { "Kuris iš šių gyvūnų yra plėšrūnas?", new List<string> { "Vilkas", "Katinas", "Šuo", "Žirafa" } },
            { "Kuris iš šių gyvūnų gyvena tik Australijoje?", new List<string> { "Koala", "Grizlis", "Vilkas", "Lūšis", } },
            { "Kuris iš šių gyvūnų yra žoleėdis?", new List<string> { "Dramblys", "Liūtas", "Hiena", "Krokodilas" } },
            { "Kuris iš šių gyvūnų gyvena ilgiausiai?", new List<string> { "Vėžlys", "Katė", "Dramblys", "Šuo" } },
            { "Kokia yra flamingo plunksnos spalva?", new List<string> { "Rožinė", "Žalia", "Mėlyna", "Geltona", } },
            { "Kuris gyvūnas laikomas žmonių evoliuciniu artimiausiu giminaičiu?", new List<string> { "Šimpanzė", "Gorila", "Orangutangas", "Bonobo" } },
            { "Kur gyvena poliariniai lokiai?", new List<string> { "Antarktidoje", "Pietų amerikoje", "Arktikoje", "Grenlandijoje" } },
            { "Koks yra didžiausias pasaulyje jūrų žinduolis?", new List<string> { "Mėlynasis banginis", "Ryklys", "Delfinas", "Jūrų liūtas" } },
            { "Kuris iš šių paukščių yra didžiausias?", new List<string> { "Afrikos strutis", "Pelikanas", "Albatrasas", "Kondoras" } },
            { "Kuris iš šių gyvūnų gali būti nuodingas?", new List<string> { "Gyvatė", "Barsukas", "Skruzdėda", "Ryklys" } },
            { "Kuris iš šių gyvūnų migruoja ilgiausią atstumą?", new List<string> { "Baltasis garnys", "Pilkasis banginis", "Antilopė", "Lokys" } },
            { "Kuris iš šių gyvūnų gyvena po vandeniu?", new List<string> { "Aštuonkojis", "Žiurkė", "Pingvinas", "Skruzdėlė" } }
        };
        static void Main(string[] args)
        {
            string loggeduser = "";
            while (true)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("**********************************************************");
                Console.WriteLine("************************ Protmūšis ***********************");
                Console.WriteLine("**********************************************************");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Sveiki, norėdami prisijungti įveskite vardą ir pavardę: ");
                Console.WriteLine();
                string username = Console.ReadLine();
                string usercheck = CheckOrAddUsersToList(username);
                if (usercheck == "badusername")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vartotojo vardas įvestas neteisingai, turi būti pvz.: Vardas Pavardė.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Spauskite ENTER, kad tęsti...");
                    Console.ReadLine();
                }
                else if (usercheck == "existuser")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    loggeduser = username;
                    Console.WriteLine($"Esamas vartotojas {loggeduser} sėkmingai prisijungtas prie žaidimo.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Spauskite ENTER, kad tęsti...");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    loggeduser = username;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Sukurta nauja paskyra ir vartotojas {loggeduser} sėkmingai prisijungtas.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Spauskite ENTER, kad tęsti...");
                    Console.ReadLine();
                }
                while (loggeduser != "")
                {
                    Console.Clear();
                    Console.WriteLine();
                    ShowLoggedUser(loggeduser);
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Pasirinkite:");
                    Console.WriteLine();
                    ShowMenu();
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.Clear();
                            loggeduser = UserLogOut(loggeduser);
                            break;
                        case "2":
                            Console.Clear();
                            ShowLoggedUser(loggeduser);
                            Console.WriteLine("----------------------------------------------------------------------------");
                            PrintGamesRules(loggeduser);
                            break;
                        case "3":
                            Console.Clear();
                            ShowLoggedUser(loggeduser);
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Pasirinkite: ");
                            Console.WriteLine();
                            Console.WriteLine("1. Žaidimo dalyvių sąrašas");
                            Console.WriteLine("2. Žaidimo rezultatai");
                            string choice2 = Console.ReadLine();
                            switch (choice2)
                            {
                                case "1":
                                    Console.Clear();
                                    ShowLoggedUser(loggeduser);
                                    Console.WriteLine("----------------------------------------------------------------------------");
                                    PrintGameParticipants(loggeduser);
                                    break;
                                case "2":
                                    Console.Clear();
                                    ShowLoggedUser(loggeduser);
                                    Console.WriteLine("----------------------------------------------------------------------------");
                                    PrintUsersTopTable(loggeduser, SortUsersResults());
                                    break;
                            }
                            break;
                        case "4":
                            Console.Clear();
                            ShowLoggedUser(loggeduser);
                            Console.WriteLine("----------------------------------------------------------------------------");
                            PlayGame(loggeduser);
                            break;
                        case "5":
                            Console.Clear();
                            ShowLoggedUser(loggeduser);
                            Console.WriteLine("----------------------------------------------------------------------------");
                            CloseApplication();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine();
                            ShowLoggedUser(loggeduser);
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Pasirinkite:");
                            Console.WriteLine();
                            ShowMenu();
                            break;
                    }
                }
            }
        }
        public static string CheckOrAddUsersToList(string username)
        {
            // Regex šablonas vartotojo vardo patikrinimui
            string pattern = @"^[A-Z][a-z]+ [A-Z][a-z]+$";
            if (users.ContainsKey(username)) return "existuser";
            // Vartotojo vardo patikrinimas pagal regex šabloną
            else if (Regex.IsMatch(username, pattern))
            {
                users.Add(username, 0);
                return username;
            }
            else return "badusername";
        }
        public static string UserLogOut(string loggeduser)
        {
            Console.Write($"Vartotojas ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(loggeduser);
            Console.ResetColor();
            Console.WriteLine(" atsijungė");
            Console.WriteLine();
            Console.WriteLine("Spauskite ENTER, kad tęsti...");
            loggeduser = "";
            Console.ReadLine();
            return loggeduser;
        }
        public static void PrintGamesRules(string loggeduser)
        {
            Console.Clear();
            Console.WriteLine();
            ShowLoggedUser(loggeduser);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Žaidimo taisyklės");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Sveikiname prisijungus prie protmūšio programos. Šiame žaidime jums reikės atsakyti į 10 klausimų." +
                              "Atsakant į klausimus jums bus pateikti 4 atsakymų variantai, reikės išsirinkti 1 teisingą variantą." +
                              "Už kiekvieną teisingą atsakymą gausite po 1 tašką. Jei atsakysite neteisingai, taškai nebus priskiriami." +
                              "Žaisdami galite pasinaudoti pagalba parašę d ir paspaudę enter, kuri panaikins du neteisingus atsakymus.");
            Console.WriteLine();
            Console.WriteLine("Paspauskite 'q' jei norite grįžti atgal");
            while (Console.ReadKey(true).Key != ConsoleKey.Q);
        }
        public static void PrintGameParticipants(string loggeduser)
        {
            Console.Clear();
            Console.WriteLine();
            ShowLoggedUser(loggeduser);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Registruoti žaidimo dalyviai");
            Console.WriteLine();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}");
            }
            Console.WriteLine();
            Console.WriteLine("Paspauskite 'q' jei norite grįžti atgal");
            while (Console.ReadKey(true).Key != ConsoleKey.Q) ;
        }
        public static List<KeyValuePair<int, List<string>>> SortUsersResults()
        {
            // sudedame vartotojus iš dictionary į sąrašą
            var userslist = users.ToList();
            // Sukuriame dictionary, kuriame bus saugomos vartotojų grupės pagal taškus
            Dictionary<int, List<string>> groupedUsers = new Dictionary<int, List<string>>();
            // Ciklas, kuris eina per visus vartotojus ir surūšiuoja juos pagal taškus į grupes
            for (int i = 0; i < users.Count; i++)
            {
                var user = userslist[i];
                var score = user.Value;
                var userName = user.Key;
                // Patikriname ar toks taškų kiekis jau yra grupuotas
                if (!groupedUsers.ContainsKey(score))
                {
                    // Jei nėra tokio taškų kiekio grupėje, sukuriam naują ir pridedam vartotoją į sąrašą
                    groupedUsers[score] = new List<string> { userName };
                }
                else
                {
                    // Jei egzistuoja, pridedame vartotoją prie esamos grupės sarašo
                    groupedUsers[score].Add(userName);
                }
            }
            // Surūšiuojame grupes pagal taškus nuo didžiausio iki mažiausio
            var sortedGroup = groupedUsers.OrderByDescending(x => x.Key).ToList();
            return sortedGroup;
        }
        public static void PlayGame(string loggeduser)
        {
            Console.Clear();
            int points = 0;
            int questionnr = 1;
            int gameHelp = 1;
            string showanser = "";
            ShowLoggedUser(loggeduser);
            Console.WriteLine("----------------------------------------------------------------------------");
            Dictionary<string, string> questionsResults = new Dictionary<string, string>();
            // Sudedame klausimus į sąrašą ir juos sumaišome
            List<string> questionKeys = questionsAnimals.Keys.ToList();
            var randomquestion = questionKeys.ToArray();
            Random.Shared.Shuffle(randomquestion);
            // Ciklas kalusimų atvaizdavimui ir atsakymų įvedimui
            foreach (var question in randomquestion)
            {
                bool questionAnsweredCorrectly = false;
                // Paimami klausimo atsakymai ir sumaišomi
                List<string> answers = questionsAnimals[question];
                var randomanswers = answers.ToArray();
                Random.Shared.Shuffle(randomanswers);
                while (!questionAnsweredCorrectly)
                {
                    Console.Clear();
                    ShowLoggedUser(loggeduser);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"Klausimas {questionnr} iš 10");
                    Console.WriteLine($"Jūsų taškai: {points}");
                    if (gameHelp == 1)
                    {
                        Console.WriteLine("Galite pasinaudoti pagalba, kuri panaikins du neteisingus atsakymus. Jei norite pasinaudoti rašykite d.");
                    }
                    Console.WriteLine();
                    Console.WriteLine(question);
                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"{i + 1}. {randomanswers[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Pasirinkite atsakymą: ");
                    Console.WriteLine();
                    string useranswer = Console.ReadLine();
                    if (useranswer == "d" && gameHelp == 1)
                    {
                        Console.Clear();
                        ShowLoggedUser(loggeduser);
                        Console.WriteLine("------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine($"Klausimas {questionnr} iš 10");
                        Console.WriteLine($"Jūsų taškai: {points}");
                        Console.WriteLine();
                        Console.WriteLine(question);
                        Console.WriteLine();
                        gameHelp--;
                        // 
                        if ((randomanswers[0]) == answers[0] || randomanswers[1] == answers[0])
                        {
                            Console.WriteLine($"{1}. {randomanswers[0]}");
                            Console.WriteLine($"{2}. {randomanswers[1]}");
                        }
                        else
                        {
                            randomanswers[1] = answers[0];
                            Console.WriteLine($"{1}. {randomanswers[0]}");
                            Console.WriteLine($"{2}. {randomanswers[1]}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Pasirinkite atsakymą: ");
                        Console.WriteLine();
                        useranswer = Console.ReadLine();
                    }
                    // String formato atsakymą paverčiame į skaičių ir patikriname ar jis yra teisingas
                    if (int.TryParse(useranswer, out int userAnswerIndex) && userAnswerIndex >= 1 && userAnswerIndex <= 4)
                    {
                        if (randomanswers[userAnswerIndex - 1] == answers[0])
                        {
                            showanser = "teisingai";
                            points++;
                            questionsResults.Add(question, showanser);
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine($"Klausimas atsakytas - {showanser}");
                            Console.ResetColor();
                        }
                        else
                        {
                            showanser = "neteisingai";
                            questionsResults.Add(question, showanser);
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine($"Klausimas atsakytas - {showanser}");
                            Console.WriteLine($"Teisingas atsakymas buvo: {answers[0]}");
                            Console.ResetColor();
                        }
                        Console.WriteLine();
                        Console.WriteLine("Pauskite ENTER, kad tęsti žaidimą...");
                        Console.ReadLine();
                        questionAnsweredCorrectly = true;
                    }
                    else
                    {
                        Console.WriteLine("Atsakymo įvedimas neteisingas, pasirinkite iš galimų variantų");
                        Console.WriteLine();
                        Console.WriteLine("Pauskite ENTER ir bandykite dar kartą...");
                        Console.ReadLine();
                    }

                }
                questionnr++;
                if (questionnr >= 10)
                {
                    break;
                }   
            }
            if (points > users[loggeduser])
            {
                users[loggeduser] = points;
            }
            Console.Clear();
            ShowLoggedUser(loggeduser);
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Iš viso surinkote taškų: {points}");
            Console.WriteLine();
            Console.WriteLine("Jūsų rezultatai ir klausimų atsakymai:");
            Console.WriteLine();
            //
            foreach (var result in questionsResults)
            {
                Console.WriteLine($"Klausimas -> {result.Key} - atsakytas: {result.Value}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Jūsų pozicija tar visų žaidėjų:");
            Console.WriteLine();
            PrintLoggedUserResultInTable(loggeduser, SortUsersResults());
            Console.WriteLine();
            Console.WriteLine("Paspauskite 'q' jei norite grįžti atgal");
            while (Console.ReadKey(true).Key != ConsoleKey.Q) ;
        }
        public static void CloseApplication()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Programa uždaryta");
            Console.ResetColor();
            Environment.Exit(0);
        }
        public static void ShowLoggedUser(string loggeduser)
        {
            Console.Write($"Prisijungęs vartotojas: ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(loggeduser);
            Console.WriteLine();
            Console.ResetColor();
        }
        public static void ShowMenu()
        {
            Console.WriteLine("1. Atsijungimas");
            Console.WriteLine("2. Žaidimo taisyklių atvaizdavimas");
            Console.WriteLine("3. Žaidimų rezultatų ir dalyvių peržiūra");
            Console.WriteLine("4. Žaidimo pradžia");
            Console.WriteLine("5. Išėjimas iš žaidimo");
            Console.WriteLine();
        }
        public static void PrintUsersTopTable(string loggeduser, List<KeyValuePair<int, List<string>>> sortedGroup)
        {
            Console.Clear();
            ShowLoggedUser(loggeduser);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Žaidimo dalyvių rezultatai");
            Console.WriteLine();
            string overallRank = "";
            // Ciklas, kuris eina per surūšiuotas grupes ir atspausdina vartotojus
            for (int rank = 0; rank < sortedGroup.Count; rank++)
            {
                string stars;
                // Nustatome žvaigždučių kiekį pagal vartotojo vietą reitinge ir bendrą reitingą
                switch (rank)
                {
                    case 0:
                        stars = "*";
                        overallRank = "1.";
                        break;
                    case 1:
                        stars = "**";
                        overallRank = "2.";
                        break;
                    case 2:
                        stars = "***";
                        overallRank = "3.";
                        break;
                    case 3:
                        stars = "";
                        overallRank = "4.";
                        break;
                    case 4:
                        stars = "";
                        overallRank = "5.";
                        break;
                    case 5:
                        stars = "";
                        overallRank = "6.";
                        break;
                    case 6:
                        stars = "";
                        overallRank = "7.";
                        break;
                    case 7:
                        stars = "";
                        overallRank = "8.";
                        break;
                    case 8:
                        stars = "";
                        overallRank = "9.";
                        break;
                    case 9:
                        stars = "";
                        overallRank = "10.";
                        break;
                    default:
                        stars = "";
                        overallRank = "";
                        break;
                }
                // sukuriamas kintamasis, kuris laiko vartotojų grupę
                var group = sortedGroup[rank];
                // iš grupės paimamas taškų kiekis ir vartotojų sąrašas
                int score = group.Key;
                List<string> usersInGroup = group.Value;
                // Ciklas, kuris eina per vartotojus grupėje ir atspausdina juos
                foreach (var user in usersInGroup)
                {
                    if (loggeduser == user)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{overallRank} {user} {stars} - jūsų taškai: {score}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"{overallRank} {user} {stars} - taškai: {score}");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Paspauskite 'q' jei norite grįžti atgal");
            while (Console.ReadKey(true).Key != ConsoleKey.Q) ;
        }
        public static void PrintLoggedUserResultInTable(string loggeduser, List<KeyValuePair<int, List<string>>> sortedGroup)
        {
            string overallRank = "";
            // Ciklas, kuris eina per surūšiuotas grupes ir atspausdina vartotojus
            for (int rank = 0; rank < sortedGroup.Count; rank++)
            {
                var group = sortedGroup[rank];
                int score = group.Key;
                List<string> usersInGroup = group.Value;
                foreach (var user in usersInGroup)
                {
                    if (loggeduser == user)
                    {
                        overallRank = $"{rank + 1}.";
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{overallRank} {user} - jūsų taškai: {score}");
                        Console.ResetColor();
                    }
                }
            }

        }
    }
}
