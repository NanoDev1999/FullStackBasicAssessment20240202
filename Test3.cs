
// Would this have any compilation issues regarding inheritance or not? Why?
public class Person
{
    string FirstName { get; set;}
    string LastName { get; }
}

public class Customer
{

}

public class WholesaleCustomer : Person, Customer
{

}

public class RetailCustomer : Person, Customer
{

}









