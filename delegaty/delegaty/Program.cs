using System;

namespace Delegty
{
  
    public class Rozkaz
    {
        public string Treść { get; set; }
    }


    public class Kapitan
    {
        public Rozkaz AktualnyRozkaz { get; private set; }


        public void WydajRozkaz()
        {
            string[] dostępneRozkazy = { "Manewr bojowy!", "Podnieś żagle!", "Przygotować armaty!" };

            Random random = new Random();
            int index = random.Next(dostępneRozkazy.Length);

            AktualnyRozkaz = new Rozkaz { Treść = dostępneRozkazy[index] };
        }
    }

    public class Marynarz
    {
        public void OdbierzRozkaz(Kapitan kapitan)
        {
            kapitan.WydajRozkaz();
            Console.WriteLine("Rozkaz przyjęty Panie Kapitanie: " + kapitan.AktualnyRozkaz.Treść);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BUM BUM BUM");
            Console.ResetColor();
        }
    }


    public class Okretowy
    {
        public void OdbierzRozkaz(Kapitan kapitan)
        {
            kapitan.WydajRozkaz();
            Console.WriteLine("Tak jest Panie Kapitanie: " + kapitan.AktualnyRozkaz.Treść);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kapitan kapitan = new Kapitan();
            Marynarz marynarz = new Marynarz();
            Okretowy okretowy = new Okretowy();

            marynarz.OdbierzRozkaz(kapitan);
            okretowy.OdbierzRozkaz(kapitan);

            Console.ReadLine();
        }
    }
}

