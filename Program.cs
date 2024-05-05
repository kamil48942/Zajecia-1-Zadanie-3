using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string nazwaPliku = "plikdoodczytu.txt";

        try
        {
            using (FileStream fs = new FileStream(nazwaPliku, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string zawartosc = sr.ReadToEnd();
                    Console.WriteLine("Zawartość pliku:");
                    Console.WriteLine(zawartosc);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }

        Console.ReadKey();
    }
}
