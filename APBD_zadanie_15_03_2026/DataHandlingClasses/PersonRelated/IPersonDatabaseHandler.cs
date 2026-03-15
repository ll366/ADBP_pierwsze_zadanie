namespace APBD_zadanie_15_03_2026;

public interface IPersonDatabaseHandler
{
    public void addPerson(Person person);
    public void removePerson(int identifier);
    public Person getPerson(getBy getBy ,int identifier);
    enum getBy
    {
        name, surname, identifier
    }
}