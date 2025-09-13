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


            //Jag ska skapa en instans av klassen Inheritance, och satt värdena för JobTitle, och sedan anropar jag metoden Introduce och Work för att skriva ut informationen.

            Inheritance myWork = new Inheritance();
            myWork.JobTitle = "Teamleader";
            person.Introduce();
            myWork.Work();

        }
    }
}
