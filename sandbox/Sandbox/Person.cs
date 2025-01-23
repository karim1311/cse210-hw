public class Person {
    private string _title;
    private string _firstName;
    private string _lastName;

    // Constructors
    public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Uknown";
    }

    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }

    public Person(string title,string first,string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }


    public string getFirstName()
    {
        return _firstName;
    }

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }
}