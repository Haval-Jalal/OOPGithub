namespace OOPGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Har skapat en instans av klassen Person, och satt värdena för Name och Age, och sedan anropar jag metoden Introduce för att skriva ut informationen.

            Person person = new Person();
            person.Name = "Haval";
            person.Age = 34;
            person.Introduce();

        }
    }
}
