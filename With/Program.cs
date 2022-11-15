var snoopy = new
{
    Name = "Snoopy",
    Breed = "Beagle"
};

var supercan = snoopy with { Name = "Supercna" };

Console.WriteLine(snoopy);
Console.WriteLine(supercan);