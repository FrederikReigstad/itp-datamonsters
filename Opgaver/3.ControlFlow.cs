using System;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine(
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
            );
            // Lav opgaven herunder!
            if (int.TryParse(Console.ReadLine(), out int number));

            if (number < 18)
            {
                Console.WriteLine("The number is bigger then 18");
            }
            else if (number > 18) 
            {
                Console.WriteLine("The number is smaller then 18");
            }
            else
            {
                Console.WriteLine("The number is 18");
            }
        }

        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            int tal;
            while (true)
            {
                Console.Write("Indtast et heltal: ");
                if (int.TryParse(Console.ReadLine(), out tal))
                {
                    break; // Gyldigt input
                }
                else
                {
                    Console.WriteLine("Ugyldigt input! Indtast venligst et heltal.");
                }
            }

            // Tjek lige eller ulige
            if (tal % 2 == 0)
            {
                Console.WriteLine($"{tal} er lige.");
            }
            else
            {
                Console.WriteLine($"{tal} er ulige.");
            }
        }

        public static void Switch1()
        {
            // Variabel til tal
            int tal;

            // Sikre gyldigt input
            while (true)
            {
                Console.Write("Indtast et heltal: ");
                if (int.TryParse(Console.ReadLine(), out tal))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ugyldigt input! Indtast venligst et heltal.");
                }
            }

            // Brug switch på tal % 2
            switch (tal % 2)
            {
                case 0:
                    Console.WriteLine($"{tal} er lige.");
                    break;
                case 1:
                    Console.WriteLine($"{tal} er ulige.");
                    break;
            }

        }

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("Program som tjekker om et tal er lige eller ulige.");

            // Variabel til tal
            int tal;

            // Sikre gyldigt input
            while (true)
            {
                Console.Write("Indtast et heltal: ");
                if (int.TryParse(Console.ReadLine(), out tal))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ugyldigt input! Indtast venligst et heltal.");
                }
            }

            // Ternary-operator til at tjekke lige/ulige
            string resultat = (tal % 2 == 0) ? "lige" : "ulige";

            Console.WriteLine($"{tal} er {resultat}.");
        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            );
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            // Lav opgaven herunder!
            int points = 0; // holder styr på rigtige svar
            string svar;
            // Spørgsmål 1
            Console.WriteLine("Spørgsmål 1: Hvad er religion i Danmark?");
            svar = Console.ReadLine().ToLower(); // .ToLower så store/små bogstaver ikke betyder noget
            if (svar == "kristendommen" || svar == "christianity")
            {
                Console.WriteLine("Rigtigt!");
                points++;
            }
            else
            {
                Console.WriteLine("Forkert! Det rigtige svar er Kristendommen.");
            }

            Console.WriteLine();

            // Spørgsmål 2
            Console.WriteLine("Spørgsmål 2: Hvor mange dage er der i en uge?");
            svar = Console.ReadLine();
            if (svar == "7")
            {
                Console.WriteLine("Rigtigt!");
                points++;
            }
            else
            {
                Console.WriteLine("Forkert! Det rigtige svar er 7.");
            }

            Console.WriteLine();

            // Spørgsmål 3
            Console.WriteLine("Spørgsmål 3: Hvilket dyr kaldes 'kongens af junglen'?");
            svar = Console.ReadLine().ToLower();
            if (svar == "løve" || svar == "lion")
            {
                Console.WriteLine("Rigtigt!");
                points++;
            }
            else
            {
                Console.WriteLine("Forkert! Det rigtige svar er løven.");
            }

            Console.WriteLine();

            // Resultat
            Console.WriteLine($"Du fik {points} ud af 3 rigtige!");
        

        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            // Lav opgaven herunder!
            Console.Write("Indtast en karakter: ");
            int karakter;
            while (!int.TryParse(Console.ReadLine(), out karakter))
            {
                Console.WriteLine("Ugyldigt input! Indtast venligst et heltal.");
                Console.Write("Indtast en karakter: ");
            }

            // Brug switch til feedback
            switch (karakter)
            {
                case 12:
                    Console.WriteLine("Super flot! 🌟");
                    break;
                case 10:
                    Console.WriteLine("Rigtig godt klaret! 👍");
                    break;
                case 7:
                    Console.WriteLine("Godt arbejde – der er stadig plads til forbedring.");
                    break;
                case 4:
                    Console.WriteLine("Du bestod, men der er plads til at gøre det bedre.");
                    break;
                case 02:
                    Console.WriteLine("Lige akkurat bestået – hæng i!");
                    break;
                case 00:
                    Console.WriteLine("Desværre ikke bestået. Prøv igen og lær af det.");
                    break;
                case -3:
                    Console.WriteLine("Ikke bestået. Husk, man lærer af sine fejl.");
                    break;
                default:
                    Console.WriteLine("Ukendt karakter. Brug fx 12, 10, 7, 4, 02, 00 eller -3.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Ekstra opgave: Beregn gennemsnit af flere karakterer!");

            // Ekstra opgave: flere karakterer og gennemsnit
            Console.WriteLine("Indtast flere karakterer (skriv 'stop' for at afslutte):");

            List<int> karakterer = new List<int>();
            string input;

            while (true)
            {
                Console.Write("Indtast karakter: ");
                input = Console.ReadLine().ToLower();

                if (input == "stop")
                {
                    break; // afslut løkken
                }

                if (int.TryParse(input, out int k))
                {
                    karakterer.Add(k);
                }
                else
                {
                    Console.WriteLine("Ugyldigt input! Indtast et heltal eller 'stop'.");
                }
            }

            if (karakterer.Count > 0)
            {
                double gennemsnit = karakterer.Average();
                Console.WriteLine($"Du har indtastet {karakterer.Count} karakterer. Gennemsnittet er {gennemsnit:F2}");
            }
            else
            {
                Console.WriteLine("Ingen karakterer blev indtastet.");
            }
        }
    }
}
