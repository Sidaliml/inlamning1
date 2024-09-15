
public class Spelare
{
    // Detta är det privata attributet som skyddar 
    // Vi kommer åt den bara med public metoder och public attributer 
    private string name;

    // Konstruktör - när vi skapar ett objekt av klassen Employee, krävs ett namn som specificerar attributen
    public Spelare(string  name)
    {
        name = name;
    }

    // Public metod för att komma åt privata attributer
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}



