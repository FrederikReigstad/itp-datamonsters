using System;
using System.Text;

namespace Opgaver
{
    public class Inputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            String1();
            Int1();
            Double1();
            Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }

        public static void String1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"
            );

            Console.WriteLine("Indtast en streng: ");
            // Lav opgaven herunder!
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name}!");
            Console.WriteLine();

        }

        public static void Int1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et tal: ");
            // Lav opgaven herunder!
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine($"You typed {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid number.");
                }
            }
    
            Console.WriteLine();
        }

        public static void Double1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et decimaltal: ");
            while (true)
            {
                // Lav opgaven herunder!
                if (double.TryParse(Console.ReadLine(), out double dub))
                {
                    Console.WriteLine($"You typed {dub}");
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid number.");
                }
            }
          

            Console.WriteLine();
        }

        public static void Bool1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen"
            );

            Console.WriteLine("Indtast en sandhedsværdi (sandt/falsk): ");
            // Lav opgaven herunder!
            string input = Console.ReadLine()?.ToLower();

            // Tjek dansk input først
            bool value;
            if (input == "sandt")
            {
                value = true;
            }
            else if (input == "falsk")
            {
                value = false;
            }
            else if (bool.TryParse(input, out bool b))
            {
                value = b; // håndterer true/false på engelsk
            }
            else
            {
                Console.WriteLine("Ugyldigt input – prøv igen.");
                return;
            }

            Console.WriteLine($"Du indtastede: {value}");

        }

        // Mini-projekt: Personlig profil (skabelon)
        public static void MiniProjekt1()
        {
            Console.WriteLine("\nMini-projekt: Personlig profil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster sit navn, alder og hjemby.");
            Console.WriteLine(
                "Gem oplysningerne i variabler og udskriv en præsentationstekst, der bruger alle oplysningerne."
            );
            Console.WriteLine("Eksempel: Hej, jeg hedder X, er X år gammel og kommer fra X!");
            // Lav opgaven herunder!
            Console.WriteLine("Input Name: ");
            string name = Console.ReadLine();
            // Input alder med while-loop, så vi er sikre på at få et tal
            int age;
            while (true)
            {
                Console.Write("Input Age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break; // Vi har fået en gyldig alder, så vi kan stoppe loopet
                }
                else
                {
                    Console.WriteLine("Ugyldigt input! Indtast venligst et tal.");
                }
            }
            Console.WriteLine("Input Where you from: ");
            string kommerFra = Console.ReadLine();

            Console.WriteLine($"");
            Console.WriteLine($"Hej, jeg hedder {name}, er {age} år gammel og kommer fra {kommerFra}!");
            Console.WriteLine();

        }

        // Mini-projekt 2: BMI-beregner (skabelon)
        public static void MiniProjekt2()
        {
            Console.WriteLine("\nMini-projekt 2: BMI-beregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster sin vægt (i kg) og højde (i meter)."
            );
            Console.WriteLine("Programmet skal beregne brugerens BMI og udskrive resultatet.");
            Console.WriteLine(
                "Tip: BMI beregnes som vægt divideret med højde i anden (BMI = vægt / (højde * højde))."
            );
            double vaegt;
            while (true)
            {
                Console.Write("Indtast din vægt i kg: ");
                if (double.TryParse(Console.ReadLine(), out vaegt) && vaegt > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ugyldigt input! Indtast et positivt tal.");
                }
            }

            // Input højde
            double højte;
            while (true)
            {
                Console.Write("Indtast din højde i Cm: ");
                if (double.TryParse(Console.ReadLine(), out højte) && højte > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ugyldigt input! Indtast et positivt tal.");
                }
            }
            // hojde/100 = hojdeCm
            // Beregn BMI
            højte = højte / 100;
            double bmi = vaegt / (højte * højte);
            string ending;
            if (bmi < 18.5)
            {

                ending = "er du undervægtig.";

            }

            else if (bmi < 25)
            {

                ending = "har du en normal vægt.";

            }

            else if (bmi < 30)
            {

                ending = "er du overvægtig.";

            }

            else if (bmi < 35)
            {

                ending = "er du svært overvægtig.";

            }

            else
            {

                ending = "er du ekstremt overvægtig.";

            }

            // Udskriv resultat
            Console.WriteLine($"Din BMI er: {bmi:F2} og dermed {ending}");

        }
    }
}
