Console.WriteLine("Hello, OOP");
Console.WriteLine(" ");


// Part 1
var p1 = new Person("Jacko", "Mitiam", new DateOnly(1998, 09, 04));

var p2 = new Person("PersonX", "PersonY", new DateOnly(1997, 04, 09));

p1.Pets.Add(new Dog("Cat", "Hotdog", new DateOnly (2005,05,25)));
p1.Pets.Add(new Dog("Dino", "Dinosaur", new DateOnly (2006,05,25)));

p2.Pets.Add(new Cat("Dog", "Persian", new DateOnly(2007, 05, 25)));

List<Person> people = [p1, p2];

foreach(var p in people)
{
    
    Console.WriteLine($"{p}");

    foreach (var pet in p.Pets)
    {
        Console.WriteLine($"{pet}");
    }
    Console.WriteLine(" ");
}

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get; set; } = firstname;

    public string Last {get; set;} = lastname;

    public DateOnly Birthday { get; set; } = birthday;

    public List<Pet> Pets { get; } = new();

    public override string ToString()
    {
        return $"Im {First} {Last} Owner of this Pet(s):";
    }
}


// part 2
public abstract class Pet(string firstname, string breed, DateOnly dob)
{
    public string First { get; } = firstname;

    public string Breed { get;} = breed;

    public DateOnly Dob { get;  } = dob;

    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"My Name is {First} I'm a {Breed} {GetType().Name} born {Dob} and I {MakeNoise()} Look!";
    }

}

public class Dog(string firstname, string breed, DateOnly dob) : Pet(firstname, breed, dob)
{
    public override string MakeNoise() => "bark";
}

public class Cat(string firstname, string breed, DateOnly dob) : Pet(firstname, breed, dob)
{
    public override string MakeNoise() => "meow";
}
