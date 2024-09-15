namespace inlämning
{
    // POLYMORPHISM EXEMPEL

    public class Fordon()

    {
        public string typ;

        public string modell;

        public virtual void motor()
        {
            Console.WriteLine("bilen kors med motor");

        }
            
    }

    public class cykel : Fordon
    {
        public override void motor()
        {
            Console.WriteLine("Cykeln trampar man för att aka");

        }
    }

    public class bil : Fordon
    {
        public override void motor()
        {
            Console.WriteLine("bilen kör man för att aka");

        }
    }

}
