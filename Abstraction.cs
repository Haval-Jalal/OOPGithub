namespace OOPGithub
{

    // Här skapar jag en abstrakt klasss som heter Animal. Den ska inne hålla viss info med 2 attributer och en metod som jag vill ska finnas på alla andra subklasser.
    public abstract class Animal 
    {
        public string Name;
        public int Weight;
        public void WeightInfo()
        {
            Console.WriteLine($"The weight of this animal is {Weight} kg");
        }
    

    }


    // Här nedan har jag skapat 2 subklasser som jag valt att inte lägga på extra attributer och metoder utan kör med det som ärvts från huvudklassen.
    //Jag kommer fylla i med värde i program.cs och köra i konsol.

    public class Horse : Animal 
    {
      
    
    }


    public class Cow : Animal

    {
    
    }

}
