namespace QueueAssignment;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> uppgifter = new Queue<string>();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till en uppgift");
            Console.WriteLine("2. Visa nästa uppgift");
            Console.WriteLine("3. Ta bort en uppgift");
            Console.WriteLine("4. Visa alla uppgifter");
            Console.WriteLine("5. Avsluta");

            string val = Console.ReadLine()!;
            Console.WriteLine($"Du valde: {val}");

            if (uppgifter.Count == 0 && (val == "2" || val == "3"))
            {
                Console.WriteLine("Det finns inga uppgifter i kön.");
                continue;
            }

            switch (val)
            {
                case "1":
                    //Ber användaren att skriva in uppgiften
                    Console.WriteLine("Ange uppgiften:");
                    string nyUppgift = Console.ReadLine()!;
                    uppgifter.Enqueue(nyUppgift);
                    Console.WriteLine($"Uppgiften '{nyUppgift}' har lagts till.");
                    break;
                    //Om använder väljer att titta på nästa uppgift, "peek" tittar bara utan att ta bort något.
                case "2":
                    Console.WriteLine("Nästa uppgift:");
                    Console.WriteLine(uppgifter.Peek());
                    break;
                    //Om användaren vill ta bort nästa uppgift, "dequeue" tar bort uppgiften som lades till först.
                case "3":
                    Console.WriteLine("Ta bort nästa uppgift:");
                    string borttagenUppgift = uppgifter.Dequeue();
                    Console.WriteLine($"Uppgiften '{borttagenUppgift}' har tagits bort.");
                    break;
                case "4":
                    Console.WriteLine("Alla uppgifter i kön:");
                    foreach (var uppgift in uppgifter)
                    {
                        Console.WriteLine(uppgift);
                    }
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Programmet avslutas.");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
}
