using System;

namespace L2_7_Zad_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program zmieni ocenę ucznia na jej opis.");
            Console.Write("Podaj ocenę od 1 do 6: ");
            byte.TryParse(Console.ReadLine(), out byte rating);

            switch (rating)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Podana liczba nie zawiera się w systemie ocen.");
                    break;
            }
        }
    }
}
