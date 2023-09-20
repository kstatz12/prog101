public class Item
{
    public float Price { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Item(float price, string name, string description)
    {
        this.Price = price;
        this.Name = name;
        this.Description = description;
    }

    public string FormatForList()
    {
        return $"Name: {this.Name}, Price: {this.Price}";
    }

    public string FormatForDetails() {
        return $"{this.Description}";
    }

    public void Print(string format)
    {
        if(format == "display")
        {
            Console.WriteLine(this.FormatForDetails());
        }
        else {
            Console.WriteLine(this.FormatForList());
        }
    }
}

public class Store
{
    private Item ItemOne = new Item(1.99f, "Candy", "Its Candy");

    private Item ItemTwo = new Item(2.99f, "Sandwich", "ham and cheese");

    public void DisplayItems()
    {
        ItemOne.Print("list");
        ItemTwo.Print("display");
    }
}
