class Customer
{
    public string LastName { get; private set; }
    public string FirstName { get; private set; }

    public Customer(string lastName, string firstName)
    {
        this.LastName = lastName;
        this.FirstName = firstName;
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName}";
    }
}