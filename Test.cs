

// Is the following code valid or not? Why?

public interface IPerson
{
    string FirstName { get; }
    string LastName { get; }
}

public class Employee : IPerson
{
    public string EmployeeType {get; set;}
}