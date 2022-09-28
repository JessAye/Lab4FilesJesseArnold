using System.IO.Compression;

namespace Lab5FilesJesse_Arnold;

public class Person
{
    private string firstName;
    private string lastName;
    private Address address;
    private string city;
    private string state;
    private string zip;

    public Person(string firstName,string lastName,Address address)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
    }
    public override string ToString()
    {
        return $"{firstName}|{lastName}|{address.StreetAddress}|{address.City}|{address.State}|{address.Zip}";
    }


}

public class Address
{
    private string streetAddress { get; init; }
    private string city { get; init; }
    private string state { get; init; }
    private string zip { get; init; }

    public Address(string streetAddress, string city, string state, string zip)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.zip = zip;
    }
    public string StreetAddress
    {
        get { return streetAddress; }
        init { streetAddress = value; }
    }
    public string City
    {
        get { return city; }
        init { city = value; }
    }
    public string State
    {
        get { return state; }
        init { state = value; }
    }
    public string Zip
    {
        get { return zip; }
        init { zip = value; }
    }
}

