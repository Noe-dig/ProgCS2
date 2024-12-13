
namespace Functions
{
    internal class Program
    {
        Random rnd = new();
        string[] vragen = new string[]
            {
                "Wat is 3-3","Waarom?","Wie is de 2e president van Amerika?","Pepperoni of salami?","Welke kleur is de lucht?"
            };

        static void Main(string[] args) //return type = void
        {
            Program program = new Program(); //hier word de variable program aangemaakt
            program.Run();
        }

        private void Run()
        {
            Console.WriteLine("Antwoord met ja of nee");
            Vraag1();
            string Vraag0 = GetVraag(0);
            Console.WriteLine(Vraag0);
            string antwoord7 = Vraag7();
            Console.WriteLine(antwoord7);
        }

        internal void AskRandomQuestion()
        {
            string vraag = GetRandomVraag();
            int vraagIndex = rnd.Next(vragen.Length);
        }

        internal string GetVraag(int vraagIndex)
        {

            return vragen[vraagIndex];
            
        }

        internal void Vraag1()
        {
            Console.WriteLine("Vraag 1: Pizza of patat?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

            Vraag2();
        }
        internal void Vraag2()
        {
            Console.WriteLine("Vraag 2: Waarom wel/niet?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

            Vraag3();
        }
        internal void Vraag3()
        {
            Console.WriteLine("Vraag 3: Wat is 3+3?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

            Vraag4();
        }
        internal void Vraag4()
        {
            Console.WriteLine("Vraag 4: Fout");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

            Vraag5();
        }
        internal void Vraag5()
        {
            Console.WriteLine("Vraag 5: Mango*3?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

            Vraag6();
        }
        internal void Vraag6()
        {
            Console.WriteLine("Vraag 6: Heb je dit ingevuld?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal string Vraag7()
        {
            Console.WriteLine("Vraag7");
            string antwoord = Console.ReadLine();

            

            return antwoord;
        }

        internal string GetRandomVraag()
        {
            int vraagIndex = rnd.Next(vragen.Length);
            return GetVraag(vraagIndex);
        }
    }

}
