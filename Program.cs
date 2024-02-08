
//  Random random = new Random();

//         // Simulera tärningskast
//         int tarning1 = random.Next(1, 7); // Slumpa ett heltal mellan 1 och 6
//         int tarning2 = random.Next(1, 7);

//         // Skriv ut resultatet
//         if (tarning1 == tarning2)
//         {
//             Console.WriteLine($"Två {tarning1}");
//         }
//         else
//         {
//             Console.WriteLine($"En {tarning1} och en {tarning2}");
//         }





// Random random = new Random();

// int tarningKast1 = random.Next(1, 7); 
// int tarningKast2 = random.Next(1, 7);
// int tarningKast3 = random.Next(1, 7);

// if (tarningKast1 == tarningKast2 && tarningKast2 == tarningKast3 && tarningKast1 == tarningKast3) {
//     Console.WriteLine($"Tre {tarningKast1}");
// }
// else if (tarningKast1 == tarningKast2 || tarningKast1 == tarningKast3 || tarningKast2 == tarningKast3)
// {
//     Console.WriteLine($"Två {tarningKast1}, en {tarningKast2} ");
// }

//    else
//         {
//             Console.WriteLine($" En {tarningKast1} och en {tarningKast2} och en {tarningKast3}");
//      }


//  Console.WriteLine("Mata in registreringsnummer:");
//     string input = Console.ReadLine();

//     if (IsValidRegistrationNumber(input))
//     {
//         Console.WriteLine("Ja");
//     }
//     else
//     {
//         Console.WriteLine("Nej");
//     }


// static bool IsValidRegistrationNumber(string input)
// {
//     // Kontrollera att längden är 6 tecken
//     if (input.Length != 6)
//         return false;

//     // Kontrollera att de första tre tecknen är bokstäver och de sista tre är siffror
//     if (char.IsLetter(input[0]) && char.IsLetter(input[1]) && char.IsLetter(input[2]) &&
//         char.IsDigit(input[3]) && char.IsDigit(input[4]) && char.IsDigit(input[5]))
//     {
//         return true;
//     }

//     // Kontrollera alternativet: de första tre tecknen är bokstäver, sedan två siffror och en bokstav
//     if (char.IsLetter(input[0]) && char.IsLetter(input[1]) && char.IsLetter(input[2]) &&
//         char.IsDigit(input[3]) && char.IsDigit(input[4]) && char.IsLetter(input[5]))
//     {
//         return true;
//     }

//     return false;
// }





//Console.WriteLine("Mata in registreringsnummer:");
//     string input = Console.ReadLine();

//     if (IsValidRegistrationNumber(input))
//     {
//         Console.WriteLine("Ja");
//     }
//     else
//     {
//         Console.WriteLine("Nej");
//     }


// static bool IsValidRegistrationNumber(string input)
// {
//     // Kontrollera att längden är 6 tecken
//     if (input.Length != 6)
//         return false;

//     // Kontrollera att de första tre tecknen är bokstäver och de sista tre är siffror
//     if (char.IsLetter(input[0]) && char.IsLetter(input[1]) && char.IsLetter(input[2]) &&
//         char.IsDigit(input[3]) && char.IsDigit(input[4]) && char.IsDigit(input[5]))
//     {
//         return true;
//     }

//     // Kontrollera alternativet: de första tre tecknen är bokstäver, sedan två siffror och en bokstav
//     if (char.IsLetter(input[0]) && char.IsLetter(input[1]) && char.IsLetter(input[2]) &&
//         char.IsDigit(input[3]) && char.IsDigit(input[4]) && char.IsLetter(input[5]))
//     {
//         return true;
//     }

//     return false;
// }


// using System;
// using System.Linq;

// namespace PasswordValidation
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Testa några lösenord
//             string[] passwords = { "Hej12345", "Losen!123", "HoppAbc!12", "HkJert567123!", "MySecurePassword123!" };

//             foreach (string password in passwords)
//             {
//                 bool isValid = IsValidPassword(password);
//                 Console.WriteLine($"Lösenordet \"{password}\" är giltigt: {isValid}");
//             }
//         }

//         static bool IsValidPassword(string password)
//         {
//             // Validera längden på lösenordet
//             if (password.Length < 8)
//                 return false;

//             // Validera antal stora och små bokstäver
//             int uppercaseCount = password.Count(char.IsUpper);
//             int lowercaseCount = password.Count(char.IsLower);
//             if (uppercaseCount < 2 || lowercaseCount < 2)
//                 return false;

//             // Validera att det finns minst ett specialtecken
//             if (password.All(char.IsLetterOrDigit))
//                 return false;

//             // Kontrollera om lösenordet innehåller förbjudna fraser (case insensitive)
//             string[] forbiddenPhrases = { "hej", "lösen", "hopp" };
//             foreach (string phrase in forbiddenPhrases)
//             {
//                 if (password.ToLower().Contains(phrase.ToLower()))
//                     return false;
//             }

//             // Alla valideringar har passerat, lösenordet är giltigt
//             return true;
//         }
//     }
// }


// using System;

// namespace Stensaxpåse
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Random random = new Random();
//             int KompiutersVal = random.Next(1, 5); // Slumpmässigt val: 1 (sten), 2 (sax), 3 (påse), 4 (hemligt)

//             Console.WriteLine("Välkommen till Sten, Påse, sax!");
//             Console.WriteLine("Välj ditt alternativ:");
//             Console.WriteLine("1. Sten");
//             Console.WriteLine("2. PÅse");
//             Console.WriteLine("3. Sax");
//             Console.WriteLine("Ditt val: ");
//             int spelaresVal = Convert.ToInt32(Console.ReadLine());

//             // Visa vad datorn valde
          
//             switch (KompiutersVal)
//             {
//                 case 1:
//                     Console.WriteLine("Datorn valde: Sten");
//                     break;
//                 case 2:
//                     Console.WriteLine("Datorn valde: Påse");
//                     break;
//                 case 3:
//                     Console.WriteLine("Datorn valde: Sax");
//                     break;
//                 case 4:
//                     Console.WriteLine("Datorn valde: Hemligt");
//                     break;
//             }

//             // Bestäm vinnare
//             if (spelaresVal == KompiutersVal)
//             {
//                 Console.WriteLine("Det blev oavgjort!");
//             }
//             else if ((spelaresVal == 1 && KompiutersVal == 3) || (spelaresVal == 2 && KompiutersVal == 1) || (spelaresVal == 3 && KompiutersVal == 2) || (KompiutersVal == 4))
//             {
//                 Console.WriteLine("Grattis, du vann!");
//             }
//             else
//             {
//                 Console.WriteLine("Datorn vann, bättre lycka nästa gång!");
//             }
//              Console.WriteLine("Tryck enter för att tillbacka ");
//             Console.ReadLine();
//         }
//     }
// }
