using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using System.Xml.Linq;

namespace Opgaver
{
    public class Loops
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Loops både med og uden datastrukturer!");
            //Loop1();
            //Loop2();
            //Loop3();
            //Loop4();
            //Loop5();
            //Loop6();
            //Loop7();
            //Loop8();
            Loop9();
            //Loop10();
            //BankeBøf();
            //MiniProjektLommeregner();
        }

        public static void Loop1()
        {
            Console.WriteLine("Opgave 1:");
            Console.WriteLine("Brug et loop til at udskrive tallene fra 1 til 10.");
            // Lav opgaven herunder!
            // A for loop that starts at 0 and runs as long as i is less than 11
            for (int i = 0; i < 11; i++)
            {
                // Print the current value of i
                Console.WriteLine(i);

                // Print an empty line for spacing
                Console.WriteLine();
            }
        }

        public static void Loop2()
        {
            Console.WriteLine("Opgave 2:");
            Console.WriteLine("Brug et loop og en if-betingelse til at udskrive alle lige tal fra 2 til 20.");
            // Lav opgaven herunder!
            for (int i = 2; i <= 20; i++)  // loop fra 2 til 20
            {
                if (i % 2 == 0)            // tjekker om tallet er lige
                {
                    Console.WriteLine(i);  // udskriver tallet
                }
            }
        }

        public static void Loop3()
        {
            Console.WriteLine("Opgave 3:");
            Console.WriteLine("Brug et loop til at lægge alle tal fra 1 til 100 sammen og udskriv resultatet.");
            // Lav opgaven herunder!
            int sumTotal = 0;
            for (int i = 0; i < 101; i++)
            {
                sumTotal = sumTotal + i;
                // Print an empty line for spacing
            }
            Console.WriteLine(sumTotal);

            Console.WriteLine();
        }

        public static void Loop4()
        {
            Console.WriteLine("Opgave 4:");
            Console.WriteLine("Bed brugeren om at indtaste sit navn og et tal. Udskriv navnet det antal gange ved hjælp af et loop.");
            // Lav opgaven herunder!

            int number;

            Console.WriteLine("Skriv dit navn");
            string name = Console.ReadLine();


            Console.WriteLine("Skriv antal gane du øsnker udskrivet");
            if (int.TryParse(Console.ReadLine(), out number))

                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine($"Mit navn er {name}");
                    Console.WriteLine();
                }

        }

        public static void Loop5()
        {
            Console.WriteLine("Opgave 5:");
            Console.WriteLine("Bed brugeren om at indtaste et tal. Brug et loop til at udskrive alle tal fra det indtastede tal og ned til 1.");
            // Lav opgaven herunder!

            Console.Write("Skriv tallet du ønsker udskrevet ned til 1: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                // Loop from number down to 1
                for (int i = number; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Det var ikke et gyldigt tal.");
            }
        }

        public static void Loop6()
        {
            Console.WriteLine("Opgave 6:");
            Console.WriteLine(@"Brug et loop til at udskrive alle bogstaverne i dit navn (ét bogstav pr. linje). 
            Navnet skal være gemt i en string variabel.");
            // Lav opgaven herunder!
            string tekst = Console.ReadLine();
            for (int i = 0; i < tekst.Length; i++)
            {
                Console.WriteLine(tekst[i]);
            }
        }

        public static void Loop7()
        {
            Console.WriteLine("Opgave 7:");
            Console.WriteLine("Brug et loop til at tælle, hvor mange gange bogstavet 'a' optræder i en tekst, som brugeren indtaster.");
            // Lav opgaven herunder!
            char letterA = 'a';
            int numberOfAs = 0;
            string tekst = Console.ReadLine().ToLower();
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] != letterA)
                {
                    Console.WriteLine("Found letter A");
                    Console.WriteLine();
                    numberOfAs++;
                }
            }
            Console.WriteLine($"total number of a's {numberOfAs}");
        }

        public static void Loop8()
        {
            Console.WriteLine("Opgave 8:");
            Console.WriteLine("Brug et loop til at udskrive alle ulige tal mellem 1 og 50.");
            // Lav opgaven herunder!
            for (int i = 0; i < 51; i++)
            {
                if(i % 2 == 1 )
                {
                    Console.WriteLine($"{i}");
                    Console.WriteLine();
                }
            }
        }

        public static void Loop9()
        {
            Console.WriteLine("Opgave 9:");
            Console.WriteLine("Bed brugeren om at indtaste 5 tal (ét ad gangen). Brug et loop til at lægge dem sammen og udskriv summen til sidst.");
            // Lav opgaven herunder!

            int sum = 0;
 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Indtast et tal:");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine("Summen er: " + sum);
        }

        public static void Loop10()
        {
            Console.WriteLine("Opgave 10:");
            Console.WriteLine("Lav et program, hvor brugeren skal gætte et hemmeligt tal mellem 1 og 10. Brug et loop, så brugeren kan gætte indtil det rigtige tal er fundet.");
            // Lav opgaven herunder!
            int guess = 0;
            Random random = new Random();
            int secret = random.Next(1, 11); // giver et tal fra 1 til 10 (øverste grænse er eksklusiv)
            while (guess != secret)
            {
                Console.Write("Gæt et tal: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secret)
                {
                    Console.WriteLine("Du gættede rigtigt!");
                }
                else
                {
                    Console.WriteLine("Forkert, prøv igen.");
                }
            }
        }

        public static void BankeBøf()
        {
            Console.WriteLine(@"Lav et program med et loop, som udskriver tallene fra 1 til 30. 
            Udskriv 'Banke' hvis tallet er deleligt med 3, 'Bøf' hvis tallet er deleligt med 5 
            og 'BankeBøf' hvis tallet er deleligt med både 3 og 5.");
            // Lav opgaven herunder!
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("BankeBøf");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Banke");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Bøf");
                }
                else
                {
                    Console.WriteLine(i);
                } 
            }
        }
        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Simpel lommeregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster to tal og vælger en regneart (+, -, * eller /).");
            Console.WriteLine("Programmet skal udregne og udskrive resultatet.");
            Console.WriteLine("Tip: Brug if/else eller switch til at vælge regnearten.");
            // Lav opgaven herunder!
            // Ask for the first number
            Console.Write("Indtast første tal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            // Ask for the second number
            Console.Write("Indtast andet tal: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            // Ask for the operation
            Console.Write("Vælg en regneart (+, -, * eller /): ");
            string regneart = Console.ReadLine();

            double resultat = 0;
            bool gyldig = true;

            // Use switch to handle the chosen operator
            switch (regneart)
            {
                case "+":
                    resultat = tal1 + tal2;
                    break;
                case "-":
                    resultat = tal1 - tal2;
                    break;
                case "*":
                    resultat = tal1 * tal2;
                    break;
                case "/":
                    if (tal2 != 0)
                        resultat = tal1 / tal2;
                    else
                    {
                        Console.WriteLine("Fejl: Division med 0 er ikke tilladt!");
                        gyldig = false;
                    }
                    break;
                default:
                    Console.WriteLine("Ugyldig regneart. Vælg mellem +, -, * eller /.");
                    gyldig = false;
                    break;
            }

            // Print result if valid
            if (gyldig)
                Console.WriteLine($"Resultat: {tal1} {regneart} {tal2} = {resultat}");
        }
    }
}