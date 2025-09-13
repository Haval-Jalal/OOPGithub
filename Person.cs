

namespace OOPGithub
{
    //Jag ska skapa en klass som heter Person, och där ska jag ha två attributer, Name och Age.
    //Ska även ha en motod som heter Introduce som skriver ut "Hello, my name is [Name] and I am [Age] years old."
    public class Person
    {
        public string Name;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}
