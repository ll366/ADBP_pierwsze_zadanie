namespace APBD_zadanie_15_03_2026;

public class Person : IComparable<Person>
{
    private string name {get;}
    private string surname{get;}
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


    public int CompareTo(Person? other)
    {
        return this.identifier - other.identifier;
    }
}