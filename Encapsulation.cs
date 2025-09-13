namespace OOPGithub
{   // 1. Jag skapar en klass som heter Encapsulation, och där ska jag ha ett privat attribut som heter code.
    public class Encapsulation
    {
        private int code;




        //3. Jag ska skapa en konstruktor som tar emot värdet för code och sätter det till det privata attributet code.
        public Encapsulation(int Code)
        {
            code = Code;
        }




        //2. För att kunnden komma åt och ändra värdet på code, ska jag skapa en public metod som heter Code, som har en get och set metod.
        public int Code
        {
          get { return code; }
          set { code = value; }

        }


        //4. Ska även ha en metod som heter DisplayCode som skriver ut värdet på code.
        public void DisplayCode()
        {
            Console.WriteLine($"The code is: {code}");
        }
    }
}
