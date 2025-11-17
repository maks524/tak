// 1. Mówimy, że będziemy używać podstawowych narzędzi (jak 'Console')
using System;

// 2. Tworzymy "pudło" na nasz program
class Program
{
    // 3. Tworzymy główny "punkt startowy" programu
    public static void Main(string[] args)
    {
    Console.WriteLine($"Ile masz lat?");
    string wiek = Console.ReadLine()??"";
    int wiek1 = Convert.ToInt32(wiek);
    int wiekza5 = wiek1 + 5;
    Console.WriteLine($"Za 5 lat będziesz mieć {wiekza5}");
    }
}