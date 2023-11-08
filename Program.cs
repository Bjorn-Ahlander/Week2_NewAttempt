
List<Product> items = new List<Product>();
Console.WriteLine("Enter q to show list");

while (true)
{
    // Get Category
    Console.Write("Input Category: ");
    string categoryInput = Console.ReadLine();
    if (categoryInput.ToLower().Trim() == "q")
    {
        break;
    }
    // Get Product Name
    Console.Write("Input Product: ");
    string productInput = Console.ReadLine();
    if (productInput.ToLower().Trim() == "q")
    {
        break;
    }

    // Get Price

    Console.Write("Input Price: ");
    string priceInput = Console.ReadLine();
    if (priceInput.ToLower().Trim() == "q")
    {
        break;
    }
    bool isValid = int.TryParse(priceInput, out int price);
    if (isValid)
    {
        Product product = new Product(categoryInput, productInput, price);
        items.Add(product);
        Console.WriteLine("The product was added to list");
    }

}

Console.WriteLine("All List");
foreach (var item in items)
{
    Console.WriteLine(item.Category.PadRight(20) + item.ProductName.PadRight(20) + item.Price);
}



class Product
{
    public Product(string category, string productName, int price)
    {
        Category = category;
        ProductName = productName;
        Price = price;
    }

    public string Category { get; set; }
    public string ProductName { get; set; }
    public int Price { get; set; }

}
//inskick till GIT-hub
//sodfhdj