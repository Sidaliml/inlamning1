namespace inlämning
{
    internal class ABSTRAKTION
    {
        // ABSTRAKTION
        // HUVUD ABSTRAKT
        public abstract class Car()
        {
            public abstract void Gas();

        }
        // SUBCLASS
        public class Gocart : Car
        {
            public override void Gas()
            {
                Console.WriteLine("Gocart gas");
            }
        }

    }
}
