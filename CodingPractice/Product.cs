class Product
{
    public string Name { get; private set; }
    public int Price { get; private set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name}: {Price}원";
    }
}