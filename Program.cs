    
    using System;
    using System.Xml.Linq;

    Console.WriteLine("skriv kategori eller avsluta med q: ");
    string category = Console.ReadLine();

    Console.WriteLine("vara: ");
    string vara = Console.ReadLine();

    Console.WriteLine("pris: ");
    string price = Console.ReadLine();

    List<Prod> prods = new List<Prod>();
    Prod prod1 = new Prod(category, vara, price);
    prods.Add(prod1);

    prods.Add.(new Prod(category, vara, price));

    Console.WriteLine("Produkter");
    Console.WriteLine("Category".PadRight(10) + "Vara".PadRight(10) + "Pris".PadRight(10));

    foreach (Prod prod1 in prods)
    {
        Console.WriteLine(prod.Category.PadRight(10) + prod.Vara.PadRight(10) + prod.Pris.PadRight(10));
    }

class Prod
{
    public Prod(string category, string vara, string price)
    {
        public Category = category;
        public Vara = vara;
        public Pris = price;
    }

    public string Category { get; set; }
    public string Vara { get; set; }
    public string Pris { get; set; }
}
