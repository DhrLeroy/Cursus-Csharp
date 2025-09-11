Console.Write("Aantal films: ");
int aantal = Convert.ToInt32(Console.ReadLine());

List<string> films = new List<string>();
for (int i = 0; i < aantal; i++)
{
    Console.Write("Titel film (van slecht naar goed): ");
    films.Add(Console.ReadLine());
}

for (int i = films.Count - 1; i >= 0; i--)
{
    Console.WriteLine($"{films.Count - i}. {films[i]}");
}