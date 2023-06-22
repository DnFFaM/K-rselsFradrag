using System;
using KørselsFradrag;

namespace KørselsFradrag
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                try
                {
                    Console.SetCursorPosition(1, 2);
                    Console.WriteLine("Begrenset KF!");
                    Console.SetCursorPosition(1, 4);

                    Console.SetCursorPosition(1, 6);
                    Console.Write("Indsæt antal arbejdsdage i alt: ");
                    double dage = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(1, 8);

                    Console.SetCursorPosition(1, 10);
                    Console.Write("Indsæt antal kilometer pr. dag: ");
                    double kilometer = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(1, 12);

                    Console.WriteLine("Skriv 1 hvis du køre på StoreBæltebroen: ");
                    Console.SetCursorPosition(1, 14);

                    Console.WriteLine("Skriv 2 hvis du køre på ØreSundbroen: ");
                    Console.SetCursorPosition(1, 16);

                    Console.Write("Hvis du har ikke kørt på nogen af dem, skriv 0: ");

                    int choice = int.Parse(Console.ReadLine());

                    Begren kf = new(kilometer, dage, choice);
                    double deduction = kf.KF();

                    switch (choice)
                    {
                        case 1:
                            Console.SetCursorPosition(1, 18);
                            Console.WriteLine("Kørselsfradrag med StoreBæltsbroen.");
                            Console.SetCursorPosition(1, 20);
                            Console.WriteLine($"Kørselsfradrag: {deduction:N2}");
                            break;
                        case 2:
                            Console.SetCursorPosition(1, 22);
                            Console.WriteLine("Kørselsfradrag med ØreSundsbroen.");
                            Console.SetCursorPosition(1, 24);
                            Console.WriteLine($"Kørselsfradrag: {deduction:N2}");

                            break;
                        case 0:
                            Console.SetCursorPosition(1, 26);
                            Console.WriteLine($"Kørselsfradrag: {deduction:N2}");
                            break;
                        default:
                            Console.SetCursorPosition(1, 26);
                            Console.WriteLine("Ugyldigt valg.");
                            break;
                    }

                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}