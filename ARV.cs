using System.Drawing;

namespace inlämning
{
    // ARV EXEMPLET 

    // DETTA BLIR HUVUDKLASSEN
    public class Animal
    {
        public string Name;

        public string Color;

        // METODER AV KLASSEN ANIMAL

        public void Eat()
        {
            Console.WriteLine("This animal eats");

        }

        public void Sleeps()
        {
            Console.WriteLine("This animal sleeps");
        }
    }
    // SUBKLASSER SOM ÄRVER FRÅN ANIMAL
    public class Cow : Animal
    {
        // NYA ATTRIBUTER + ALLA ATTRIBUTER FRAN ANIMAL
        public int fourStomach;

        // NYA METODER + ALLA METODER FRAN ANIMAL
        public new void Run()
        {
            Console.WriteLine("This animal does not run");
        }
    }


}
