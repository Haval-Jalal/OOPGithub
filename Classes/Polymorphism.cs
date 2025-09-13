namespace OOPGithub.Classes
{

        // Här skapar jag en klass som heter User, som också ärver från klassen Person.
    public class User : Person

    {
        // Jag har ändrat metoden Introduce på Person klassen till Virtual och skapat en metod som override: på klassen User.
        public override void Introduce()
        {
            Console.WriteLine($"Hello, I am a user named {Name} and I am {Age} years old.");
        }

    }
}
