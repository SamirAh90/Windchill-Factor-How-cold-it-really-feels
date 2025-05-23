/* 
 Information om "Windchill Factor: How cold it really feels" consoleapplikation.

        Detta consoleapplikation beräknar vindavkylningsfaktorn (wind chill) baserat på utomhustemperatur och vindhastighet. 

        Användaren kan välja att mata in temperatur och vindhastighet i olika enheter (km/h eller m/s). 
        Efter beräkning vid förmulär "WCT = 13.12 + 0.6215 * T - 11.37 * V^0.16 + 0.3965 * T * V^0.16" 
        𝑇 är lufttemperaturen i Celsius. 𝑉 är vindhastigheten i km/h.
        Skriver ut programmet resultatet av vindavkylningsberäkningen med två decimaler.

        Programmet använder även en standard formel för vindavkylning och kategoriserar resultatet i olika nivåer av kyla, 
        som "Cold", "Very Cold", "Risk of Frostbite" och "Severe Frostbite Risk". 

        Programmet erbjuder även en meny för att beräkna vindavkylningsfaktor eller avsluta applikationen.

        Refernser: 1- Complete C# Masterclass course på Udemy (https://www.udemy.com/course/complete-csharp-masterclass/?srsltid=AfmBOoqbgM31iC73NSkYRMTya0gbuziFMaxYnT-xdGn0gEw6oyiyrezW&couponCode=KEEPLEARNING)
                   2- Troelsen, A., & Japikse, P. (2022). Pro C# 10 with .NET 6 : foundational principles and practices in programming (11 uppl.). New York: APress. ISBN: 9781484278680.
                   3- Land, R. (2024). Introduktion till programmering (1 uppl.). Borlänge.
                   4- Stackoverflow https://stackoverflow.com/.
                   5- Microsoft Learn Challenge C# https://learn.microsoft.com/en-us/dotnet/csharp/
                   6- Windchill Factor: How cold it really feels https://www.bergfreunde.eu/wind-chill-calculator/
                   7- C# Tutorial https://www.w3schools.com/cs/cs_switch.php
                   8- C# Comments https://www.programiz.com/csharp-programming/comments

        För att kommentera porgrammet/koder har vi använt 
                1- Single Line Comments  
                2- Multi Line Comments    
                3 - XML Comments - för method

//Detta program är utvecklat av Samir Ahmad och Ludwig Lindfors.

 */


//Progrramet börjar härifrån
using System;
namespace WindchillCalc
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Ställer in textfärgen till mildblå för rubriken. Den är en standard method i själva C#.
            Console.ForegroundColor = ConsoleColor.Cyan;
            // Skriver ut rubriken och en rad linjer för att dekorera programmet
            Console.WriteLine("\t\t\t══════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("\t\t\t\t\t      Vindavkylningsfaktor Beräknare");
            Console.WriteLine("\t\t\t══════════════════════════════════════════════════════════════════════════\n");
            // Återställer textfärgen till standardfärgen. Den är en standard method i själva C#.
            Console.ResetColor();

            // Ställer in textfärgen till grön för rubriken. Den är en standard method i själva C#.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tDet här programmet beräknar vindavkylningsfaktorn baserat på utetemperatur");
            Console.WriteLine("\t\t\t\t\t\t   och vindhastighet\n");
            Console.WriteLine("\t\t\t   Formeln funkar bara mellan: 10 grader till -50 grader och 5 km / h ");
            Console.WriteLine("\t\t\t\t\t\t   till 150 km / h.");


            // Återställer textfärgen till standardfärgen. Den är en standard method i själva C#.
            Console.ResetColor();

            Console.WriteLine();
            // Ställer in textfärgen till gul för rubriken. Den är en standard method i själva C#.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t══════════════════════════════════════════════════════════════════════════\n\n");
            // Återställer textfärgen till standardfärgen. Den är en standard method i själva C#.
            Console.ResetColor();


            while (true)
            {

                // Ställer in textfärgen till röd
                Console.ForegroundColor = ConsoleColor.Red;
                // Skriver ut huvudmenyn med  röd färg och i samma postion som programmets rubrik
                Console.WriteLine("\t\t\t\t\t\t  **** Huvudmeny ****\n");
                // Återställer textfärgen till standard
                Console.ResetColor();

                // Skriver ut första alternativet i menyn, där användaren kan ange data och beräkna vindavkylningsfaktorn
                Console.WriteLine("  1 - Ange data och beräkna vindavkylningsfaktor");

                // Skriver ut alternativet för att avsluta programmet
                Console.WriteLine("  0 - Avsluta programmet\n");

                // Skriver ut en användarens val
                Console.Write("Ditt val: ");



                // Försöker läsa in användarens menyval och konvertera det till ett heltal
                // 1. `Console.ReadLine()`: Läser in användarens inmatning som en sträng.
                // 2. `int.TryParse`: Försöker konvertera strängen till ett heltal. 
                // Om konverteringen lyckas, lagras värdet i `userMenueChoice`. Om det misslyckas returneras `false`.
                // 3. Kontrollera om valet är utanför det giltiga intervallet (0 eller 1).
                if (!int.TryParse(Console.ReadLine(), out int userMenueChoice) || (userMenueChoice < 0 || userMenueChoice > 1))
                {
                    // Om inmatningen inte är ett giltigt heltal eller utanför intervallet informerar användaren
                    Console.WriteLine("Ogiltigt val! Försök igen.\n");

                    // Hoppar tillbaka till början av loopen för att låta användaren försöka igen
                    continue;
                }

                //switch används för meny
                switch (userMenueChoice)
                {

                    case 0:
                        // Skriver ut ett meddelande till användaren som informerar om att programmet kommer att avslutas om 3 sekunder.
                        Console.WriteLine("Programmet avslutas om 3 sekunder. Hej då!");

                        // Programmet pausar i 3 sekunder (3000 millisekunder) innan det avslutas.
                        System.Threading.Thread.Sleep(3000);
                        return;


                    case 1:
                        // Uppmanar användaren att mata in utetemperaturen i Celsius och försöker spara värdet i variabeln UteTemp - double.
                        // TryParse-metoden används för att validera användarens inmatning och säkerställa att ogiltiga värden hanteras.
                        Console.Write("\nVänligen ange utomhustemperaturen i Celsius: ");
                        if (!double.TryParse(Console.ReadLine(), out double UteTemp) || UteTemp >= 10)
                        {
                            // Om användaren anger utomhustemperaturen under 10 Celsius får den meddealndet
                            // eftersom förmuleren ej funker för tempertur under 10 celsius
                            // "It is defined for temperatures under the 10°C mark. 
                            //  enlgit https://www.bergfreunde.eu/wind-chill-calculator/
                            Console.WriteLine("Ogiltig inmatning! Utomhustemperaturen måste vara under 10°C.\n");

                            // `continue` hoppar tillbaka till början av loopen och låter användaren försöka igen.
                            continue;
                        }

                        // Uppmanar användaren att välja en måttenhet för vindhastighet.
                        Console.WriteLine("\nVälj enheten för vindhastighet:");
                        Console.WriteLine("  1 - Vindhastighet i km/h");
                        Console.WriteLine("  2 - Vindhastighet i m/s");
                        Console.Write("Ditt val: ");

                        // Validerar användarens inmatning för enhetsval
                        // 1. `Console.ReadLine()` läser in användarens inmatning som en sträng.
                        // 2. `int.TryParse` försöker konvertera strängen till ett heltal.
                        // Om konverteringen lyckas lagras värdet i `userUnitChoice`, annars returneras `false`.
                        // 3. Kontrollerar om det konverterade värdet ligger utanför intervallet 1 till 2.
                        if (!int.TryParse(Console.ReadLine(), out int userUnitChoice) || (userUnitChoice < 1 || userUnitChoice > 2))
                        {
                            // Om inmatningen inte är ett giltigt heltal eller om värdet är utanför intervallet
                            // informeras användaren med ett felmeddelande.
                            Console.WriteLine("Ogiltigt val! Försök igen.\n");

                            // `continue` hoppar tillbaka till början av loopen och låter användaren försöka igen.
                            continue;
                        }

                        // Ber användaren att ange en vindhastighet.
                        Console.Write("\nAnge vindhastighet: ");

                        // Validerar användarens inmatning för vindhastighet och säkerställer att den är över 5 km/h.
                        // Annars förmuleren ej funker "This means that the formula only starts being valid at a wind speed of 5 km/h.
                        //enlgit https://www.bergfreunde.eu/wind-chill-calculator/

                        if (!double.TryParse(Console.ReadLine(), out double userWindSpeed) || userWindSpeed < 5)
                        {
                            // Felmeddelande om användarens inmatning är ogiltig.
                            Console.WriteLine("Ogiltig inmatning! Vindhastighet måste vara över 5 km/h.\n");
                            // `continue` hoppar tillbaka till början av loopen och låter användaren försöka igen.
                            continue;
                        }
                        //Metoden CalcWindChill anropas för att beräkna vindavkylning baserat på utetemperaturen(UteTemp),
                        //användarens vindhastighet(userWindSpeed), och den valda enheten för vindhastigheten(userUnitChoice).
                        //Detta värde lagras i variabeln windChill av double typ.
                        double windChill = CalcWindChill(UteTemp, userWindSpeed, userUnitChoice);

                        // Skriver ut resultatet av vindavkylningsberäkningen med två decimaler.
                        // {0:F2} formaterar värdet med två decimaler.
                        Console.WriteLine(String.Format("\nVindavkylningsfaktorn är: {0:F2} °C", windChill));

                        // Kontrollerar om vindkylan är större än -25 (dvs inte så kallt)
                        if (windChill > -25)
                        {
                            // Om vindkylan är över -25, skriv ut "Cold" (Kallt)
                            Console.WriteLine("Cold");
                        }

                        // Om vindkylan är mellan -25 och -35 (inklusive)
                        //else if (windChill > -35 && windChill <= -25)
                        else if (windChill <= -25 && windChill > -35)
                        {
                            //Skriv ut "Very Cold"
                            Console.WriteLine("Very Cold");
                        }

                        // Om vindkylan är mellan -35 och -60 (inklusive)
                        else if (windChill > -60 && windChill <= -35)
                        {
                            //skriv ut "Risk of Frostbite"
                            Console.WriteLine("Risk of Frostbite");
                        }

                        // Om vindkylan är mindre än eller lika med -60, 
                        else if (windChill <= -60)
                        {
                            //skriv ut "Severe Frostbite Risk"(Allvarlig risk för frostskador)
                            Console.WriteLine("Severe Frostbite Risk");
                        }

                        Console.WriteLine();
                        // Ställer in textfärgen till gul för rubriken. Den är en standard method i själva C#.
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t══════════════════════════════════════════════════════════════════════════\n\n");
                        // Återställer textfärgen till standardfärgen. Den är en standard method i själva C#.
                        Console.ResetColor();

                        // Hoppar tillbaka till början av loopen meny.
                        continue;
                }
            }
        }

        /// <summary>
        /// Denna metod beräknar vindkylningsfaktorn (wind chill) baserat på användarens inmatning 
        /// av utomhustemperatur i Celsius och vindhastighet i antingen km/h eller m/s.
        /// </summary>
        /// <param name="outTemp">Utomhustemperaturen i grader Celsius.</param>
        /// <param name="windSpeed">Vindhastigheten. Denna parameter anges i den enhet som specificeras av 
        /// <paramref name="windSpeedUnit"/> (antingen km/h eller m/s, beroende på värdet på enhetsparametern).</param>
        /// <param name="windSpeedUnit">
        /// Måttenhet för vindhastigheten:
        /// 1 = km/h, 
        /// 2 = m/s.
        /// Om m/s väljs av användaren omvandlas vindhastigheten automatiskt till km/h innan beräkningen.
        /// </param>
        /// <returns>Den beräknade vindkylningsfaktorn (wind chill) i grader Celsius.</returns>
        static double CalcWindChill(double outTemp, double windSpeed, int windSpeedUnit)
        {
            // Omvindhastigheten är angiven i m/s (enhetsparameter 2), omvandlas den till km/h.
            if (windSpeedUnit == 2)
            {
                windSpeed *= 3.6; // Omvandla från m/s till km/h (1 m/s = 3.6 km/h)
            }

            // Vindkylningsfaktorn beräknas med hjälp av den meteorologiska vindchill-formeln.
            // Vindchill = 13.12 + (0.6215 * utomhustemperatur) - (11.37 * vindhastighet^0.16) + (0.3965 * utomhustemperatur * vindhastighet^0.16)
            return 13.12 + 0.6215 * outTemp - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * outTemp * Math.Pow(windSpeed, 0.16);
        }


    }

}
