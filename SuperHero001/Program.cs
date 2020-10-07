using System;

namespace SuperHero001
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMan clarkkent = new SuperMan("Superman","DC","Clark Kent");
            Batman bruce = new Batman("Batman", "DC", "Bruce Wayne");
            Wolverine logan = new Wolverine("Wolverine", "DC", "Logan");
            Console.WriteLine(clarkkent);
            clarkkent.Powers();
            Console.WriteLine(bruce);
            bruce.Powers();
            Console.Write(logan);
            logan.Powers();
        }
    }
}
