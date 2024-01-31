using System;

class Program
{
    static void Main()
    {
        Console.Write("Inserisci su quanti numeri vuoi lavorare: ");
        int dimensione = Convert.ToInt32(Console.ReadLine());
        int[] numeri = new int[dimensione];


        int somma = 0;
        for (int i = 0; i < dimensione; i++)
        {
            Console.Write($"Inserisci il numero {i + 1}: ");
            numeri[i] = Convert.ToInt32(Console.ReadLine());
            somma += numeri[i];
        }

        double media = (double)somma / dimensione;

        Console.WriteLine($"La somma di tutti i numeri è: {somma}");
        Console.WriteLine($"La media aritmetica è: {media}");

        Console.ReadLine();
    }
}
