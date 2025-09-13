namespace OOPGithub
{

    // Jag ska skapa en klass som heter Inheritance som ärver från klassen Person.
    // Den ska ha ett attribut som heter JobTitle och en metod som heter Work som skriver ut "I am working as a [JobTitle]."
    public class Inheritance : Person
    {
        public string JobTitle;
        public void Work()
        {
            Console.WriteLine($"I am working as a {JobTitle}.");
        }
    }
}