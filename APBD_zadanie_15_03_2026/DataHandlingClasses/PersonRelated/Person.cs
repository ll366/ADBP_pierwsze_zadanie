namespace APBD_zadanie_15_03_2026;

public class Person
{
    private string name {get; set;}
    private string surname{get; set;}
    private int identifier{get;}
    
    private static int biggestIdentifier;

    public Person(string name, string surname)
    {
        
        this.name = name;
        this.surname = surname;
        if (biggestIdentifier != 0)
        {
            identifier = biggestIdentifier;
            biggestIdentifier++;
        }
        else
        {
            identifier = 1;
            biggestIdentifier = 2;
        }
    }

    
}