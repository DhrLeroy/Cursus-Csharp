using Oefening7InleidingSmartphone___Oplossing;

var smartphones = new List<Smartphone>();

smartphones.Add(new Smartphone("Apple", "iPhone 14 Pro Max", 1499.99, 10));
smartphones.Add(new Smartphone("Samsung", "Galaxy S23 Ultra", 1299.99, 15));
smartphones.Add(new Smartphone("Google", "Pixel 7 Pro", 899.99, 20));

foreach (var phone in smartphones)
{
    Console.WriteLine($"{phone.Merk} {phone.Model}: nu aan {Math.Round(phone.Prijs * (100-phone.Kortingspercentage)/100, 2)} euro in plaats van {phone.Prijs} euro.");
}