var d = new Dog(null, null);
Console.WriteLine($"{d.Name} {d.Breed}");

public class Dog
{
    public Dog(string name, string breed)
    {
        //Validacion
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(breed);

        this.Name = name;
        this.Breed = breed;
    }

    public string Name { get; set; }
    public string Breed { get; set; }
}