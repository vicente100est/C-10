var snoopy = new
    Dog("Snoopy", new DogBreed("Beagle", new DogBreedGroup("Hound")));

Invoke(snoopy);

void Invoke(Dog d)
{
    if (d is Dog { Breed.Group.Name: "Hound" } dog)
    {
        Console.WriteLine(dog.Breed.Name);
    }
}

record DogBreedGroup(string Name);
record DogBreed(string Name, DogBreedGroup Group);
record Dog(string Name, DogBreed Breed);