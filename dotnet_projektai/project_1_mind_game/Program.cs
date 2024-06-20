using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace project_1_mind_game
{
    internal class Program
    {
        static Dictionary<string, int> users = new Dictionary<string, int>
        {
            { "Ajus Dudada", 2  },
            { "Lukas Lukis", 3  },
            { "Atas Batukas", 6  },
            { "Jonas Stulpis", 10  },
            { "Petras Petriukas", 10  },
            { "Kazys Kazlauskas", 8  },
            { "Antanas Antanaitis", 3  },
            { "Vytas Vytukas", 4  },
            { "Mantas Mantukas", 4  },
            { "Tomas Tomaitis", 9  },
            { "Rokas Rokaitis", 7  },
            { "Marius Mariukas", 1  },
            { "Darius Dariukas", 9  },
            { "Gintaras Gintukas", 2  },
            { "Kęstas Kęstukas", 5  },
            { "Rimas Rimukas", 6  },
            { "Giedrius Giedriukas", 8  },
            { "Aurimas Aurukas", 11  },
            { "Mindaugas Mindukas", 12  },
            { "Aivaras Aivukas", 4  }
        };
        static Dictionary<string, List<string>> questionsAnimals = new Dictionary<string, List<string>>
        {
            { "Kuris gyvūnas yra greičiausias sausumos gyvūnas?", new List<string> { "Gepardas", "Liūtas", "Arklys", "Antilopė" } },
            { "Kuris iš šių gyvūnų yra žinduolis?", new List<string> { "Delfinas", "Vėžlys", "Salamandra", "Krokodilas" } },
            { "Kiek kojų turi vabzdžiai?", new List<string> { "6", "4", "8", "10" } }, 
            { "Kokia gyvūnų grupė priklauso krokodilams, aligatoriams ir kaimanams?", new List<string> { "Ropliai", "Paukščiai", "Žuvys", "Žinduoliai", } },
            { "Kuris paukštis garsėja gebėjimu imituoti žmogaus kalbą?", new List<string> { "Papūga", "Žvirblis", "Gulbė", "Pelikanas" } },
            { "Kuris iš šių gyvūnų yra plėšrūnas?", new List<string> { "Vilkas", "Katinas", "Šuo", "Žirafa" } }, 
            { "Kuris iš šių gyvūnų gyvena tik Australijoje?", new List<string> { "Koala", "Grizlis", "Vilkas", "Lūšis", } },
            { "Kokia spalva yra flamingo plunksnos?", new List<string> { "Rožinė", "Žalia", "Mėlyna", "Geltona", } },
            { "Kuris gyvūnas laikomas žmonių evoliuciniu artimiausiu giminaičiu?", new List<string> { "Šimpanzė", "Gorila", "Orangutangas", "Bonobo" } },
            { "Kur gyvena poliariniai lokiai?", new List<string> { "Antarktidoje", "Pietų amerikoje", "Arktikoje", "Grenlandijoje" } },
            { "Koks yra didžiausias pasaulyje jūrų žinduolis?", new List<string> { "Mėlynasis banginis", "Ryklys", "Delfinas", "Jūrų liūtas" } },
            { "Kas yra didžiausias pasaulyje paukštis?", new List<string> { "Afrikos strutsas", "Pelikanas", "Albatrasas", "Kondoras" } },
        };
        static void Main(string[] args)
        {
            string loggeduser = "";
            while (true)
            {
                Console.Clear();
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
                    Console.BackgroundColor = ConsoleColor.Green;
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
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write($"Sukurta nauja paskyra ir vartotojas {loggeduser} sėkmingai prisijungtas.");
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
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.Clear();
                            ShowLoggedUser(loggeduser);
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.WriteLine("Pasirinkite: ");
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
                                    Console.ReadLine();
                                    break;
                                case "2":
                                    Console.Clear();
                                    ShowLoggedUser(loggeduser);
                                    Console.WriteLine("----------------------------------------------------------------------------");
                                    SortAndPrintGameResults(loggeduser);
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        case "4":
                            Console.Clear();
                            ShowLoggedUser(loggeduser);
                            Console.WriteLine("----------------------------------------------------------------------------");
                            GameStart(loggeduser);
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Clear();
                            ShowLoggedUser(loggeduser);
                            Console.WriteLine("----------------------------------------------------------------------------");
                            CloseApplication();
                            Console.ReadLine();
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
            string pattern = @"^[A-Z][a-z]+ [A-Z][a-z]+$";
            if (users.ContainsKey(username)) return "existuser";
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
            Console.BackgroundColor = ConsoleColor.Green;
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
            ShowLoggedUser(loggeduser);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Žaidimo taisyklės");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Sveikiname prisijungus prie protmūšio programos. Šiame žaidime jums reikės atsakyti į 10 klausimų. /n " +
                              "Atsakant į klausimus jums bus pateikti 4 atsakymų variantai, reikės išsirinkti 1 teisingą variantą. /n " +
                              "Už kiekvieną teisingą atsakymą gausite po 1 tašką. Jei atsakysite neteisingai, taškai nebus priskiriami. /n " +
                              "Žaidimo metu galėsite pasinaudoti vienu iš dviejų, pagalbos variantų: 50/50, ar skambutis draugui. ");
            Console.WriteLine();
            Console.WriteLine("Paspauskite 'q' jei norite grįžti atgal");
            while (true)
            {
                var key = Console.ReadKey(true); // The true parameter prevents the key from being displayed
                if (key.Key == ConsoleKey.Q)
                {
                    break; // Exits the loop immediately when 'q' is pressed
                }
            }
        }
        public static void PrintGameParticipants(string loggeduser)
        {
            Console.Clear();
            ShowLoggedUser(loggeduser);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Registruoti žaidimo dalyviai");
            Console.WriteLine();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}");
            }
        }
        public static void SortAndPrintGameResults(string loggeduser)
        {
            Console.Clear();
            ShowLoggedUser(loggeduser);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Žaidimo dalyvių rezultatai");
            Console.WriteLine();
            var sortedUserslist = users.ToList();
            Dictionary<int, List<string>> groupedUsers = new Dictionary<int, List<string>>();
            // Ciklas, kuris eina per visus vartotojus ir surūšiuoja juos pagal taškus
            for (int i = 0; i < users.Count; i++)
            {
                var user = sortedUserslist[i];
                var score = user.Value;
                var userName = user.Key;
                // Patikriname ar toks taškų kiekis jau yra grupuotas
                if (!groupedUsers.ContainsKey(score))
                {
                    // Jei ne, sukuriam naują grupę ir pridedam vartotoją
                    groupedUsers[score] = new List<string> { userName };
                }
                else
                {
                    // Jei egzistuoja, tiesiog pridedam vartotoją prie esamos grupės
                    groupedUsers[score].Add(userName);
                }
            }
            // Surūšiuojame grupes pagal taškus
            var sortedGroups = groupedUsers.OrderByDescending(g => g.Key).ToList();
            string overallRank = "";
            for (int rank = 0; rank < sortedGroups.Count; rank++)
            {
                string stars;
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
                // Gauname grupę pagal reitingą
                var group = sortedGroups[rank];
                int score = group.Key;
                List<string> usersInGroup = group.Value;
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
        }
        public static void GameStart(string loggeduser)   
        {
            Console.Clear();
            int points = 0;
            int questionnr = 1;
            string showanser = "";
            ShowLoggedUser(loggeduser);
            Console.WriteLine("----------------------------------------------------------------------------");
            Dictionary<string, string> questionsResults = new Dictionary<string, string>();
            // Sudedame klausimus į sąrašą ir juos sumaišome
            List<string> questionKeys = questionsAnimals.Keys.ToList(); 
            var randomquestion = questionKeys.ToArray(); 
            Random.Shared.Shuffle(randomquestion);
            // Ciklas, kuris eina per visus klausimus
            foreach (var question in randomquestion)
                {
                Console.Clear();
                ShowLoggedUser(loggeduser);
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"Klausimas {questionnr} iš 5");
                Console.WriteLine($"Jūsų taškai: {points}");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(question);
                Console.ResetColor();
                // Paimami klausimo atsakymai ir sumaišomi
                List<string> answers = questionsAnimals[question];
                var randomanswers = answers.ToArray();
                Random.Shared.Shuffle(randomanswers);
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1}. {randomanswers[i]}");
                }
                Console.WriteLine();
                Console.WriteLine("Pasirinkite atsakymą: ");
                string useranswer = Console.ReadLine();
                // String formato atsakymą paverčiame į skaičių ir patikriname ar jis yra teisingas
                int.TryParse(useranswer, out int userAnswerIndex);
                if (randomanswers[userAnswerIndex-1] == answers[0])
                {
                    showanser = "teisingai";
                    points++;
                    questionsResults.Add(question, showanser);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Klausimas atsakytas - {showanser}");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Pauskite ENTER, kad tęsti žaidimą...");
                    Console.ReadLine();
                }
                else
                {
                    showanser = "neteisingai";
                    questionsResults.Add(question, showanser);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Klausimas atsakytas - {showanser}");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine($"Teisingas atsakymas buvo: {answers[0]}");
                    Console.ReadLine();
                    Console.WriteLine("Pauskite ENTER, kad tęsti žaidimą...");
                    Console.ReadLine();
                }
                if (useranswer == "q")
                {
                    break;
                }
                if (questionnr >= 10)
                {
                    break;
                }
                questionnr++;
            }
            if ( points > users[loggeduser])
            {
                users[loggeduser] = points;
            }
            Console.Clear();
            ShowLoggedUser(loggeduser);
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Iš viso surinkote taškų: {points}");
            Console.WriteLine("Jūsų rezultatai ir klausimų atsakymai:");
            Console.WriteLine();
            foreach (var result in questionsResults)
            {
                Console.WriteLine($"{result.Key}, klausimas atsakytas: {result.Value}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Jūsų pozicija tar visų žaidėjų:");
            SortAndPrintGameResults(loggeduser);
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
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(loggeduser);
            Console.ResetColor();
        }
        public static void ShowMenu()
        {
            Console.WriteLine("1. Atsijungimas");
            Console.WriteLine("2. Žaidimo taisyklių atvaizdavimas");
            Console.WriteLine("3. Žaidimų rezultatų ir dalyvių peržiūra");
            Console.WriteLine("4. Žaidimo pradžia");
            Console.WriteLine("5. Išėjimas iš žaidimo");
        }
        public static void PositionInUserList(string loggeduser)
        {
            var sortedUserslist = users.ToList();
            Dictionary<int, List<string>> groupedUsers = new Dictionary<int, List<string>>();
            for (int i = 0; i < users.Count; i++)
            {
                var user = sortedUserslist[i];
                var score = user.Value;
                var userName = user.Key;
                if (!groupedUsers.ContainsKey(score))
                {
                    groupedUsers[score] = new List<string> { userName };
                }
                else
                {
                    groupedUsers[score].Add(userName);
                }
            }
            var sortedGroups = groupedUsers.OrderByDescending(g => g.Key).ToList();
            for (int rank = 0; rank < sortedGroups.Count; rank++)
            {
                var group = sortedGroups[rank];
                int score = group.Key;
                List<string> usersInGroup = group.Value;
                foreach (var user in usersInGroup)
                {
                    if (loggeduser == user)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{user} - jūsų taškai: {score} ");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
