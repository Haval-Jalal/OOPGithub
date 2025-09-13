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



            //Jag ska skapa en instans av klassen Encapsulation, och satt värdet för code via konstruktorn, och sedan anropar jag metoden DisplayCode för att skriva ut värdet på code.
            Encapsulation myEncapsulation = new Encapsulation(5136);

            myEncapsulation.DisplayCode();


            // Jag har skapat ett objket av klassen User (Polymorphism) som heter user1 som har 2 attributer och en metod.
            // På meton har jag overrideat och skrivit om texten med andra ord.

            User user1 = new User();
            user1.Name = "Lawan";
            user1.Age = 11;
            user1.Introduce();


            // Jag ska skapa ett objekt var från klsserna Horse och Cow som ärver från Animal.
            // Sedan ska jag anropa metoden i båda klasserna som också ärvs från huvudclassen Animal.

            Horse myHorse = new Horse();

            myHorse.Name = "Mustang";
            myHorse.Weight = 1000;
            myHorse.WeightInfo();

            Cow myCow = new Cow();
            myCow.Name = "Bambi";
            myCow.Weight = 500;

            myCow.WeightInfo(); 
        }
    }
}
