
// Does this code compile or not? Why?

public class Person
{
    public string FirstName {get; private set;}
}

public class Program {
    public static void Main(String[] args) {
        var person = new Person();
        person.FirstName = "John";

        Console.WriteLine($"{person.FirstName}")
    }
}
